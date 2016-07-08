using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4_key_recovery_tool
{
    class Cracker
    {
        //parameters
        int N;
        int l;
        int m;
        int nc;
        double prob_th;
        int gl;

        //permutation
        int[] S;
        int[] InvS;

        int[] C;
        int[] InvC;

        int s;
        int[] keyJ;

        //counters
        int[] sCandidates;
        double[,,] initialCounter;
        double[,] keyJCounter;
        double[,,] currCounter;

        //list of fixed bytes
        List<bool[]> allCombinations;
        int combinationsCount;

        int[] recoveredKey;

        public Cracker(int[] S, int keyLength)
        {
            N = Constants.N;
            prob_th = Constants.prob_th;
            gl = Constants.updateGroupLength;

            this.S = S;
            this.l = keyLength;
            
            ConstructInvS();
        }

        public bool guessKey(int m, int nc, out int[] guessedKey)
        {
            guessedKey = new int[l];
            return false;
        }

        /******************** DIRECT ATTACK METHODS **************/

        /** RETURNS SUGGESTION FOR KEY BYTES BASED ON VALUES OF j */
        public double[,] guessKeyBasedOnJs()
        {
            double[,] guess = new double[l, N];
            //TODO pro vsechna opakovani


            for (int y = 0; y < N; y++) //position
            {

                int first = (y == 0) ? 0 : S[y - 1];
                int second = S[y];

                int firstInv = (y == 0) ? 0 : InvS[y - 1];
                int secondInv = InvS[y];

                //nesting first
                for (int i = 1; i <= 4; i++)
                {
                    //nesting second
                    for (int j = 1; j <= 4; j++)
                    {
                        //all combinations of J
                        if ((i > 1 | second >= y) & (j > 1 | (y == 0 | first >= y - 1)))
                            guess[y % l, mod(J(y + 1, i, false) - J(y, j, false) - y, N)] += weightJ(y + 1, i, false) * weightJ(y, j, false);
                        if ((i > 1 | second >= y) & (j > 1 | (y == 0 | firstInv <= y - 1)))
                            guess[y % l, mod(J(y + 1, i, false) - J(y, j, true) - y, N)] += weightJ(y + 1, i, false) * weightJ(y, j, true);
                        if ((i > 1 | secondInv <= y) & (j > 1 | (y == 0 | first >= y - 1)))
                            guess[y % l, mod(J(y + 1, i, true) - J(y, j, false) - y, N)] += weightJ(y + 1, i, true) * weightJ(y, j, false);
                        if ((i > 1 | secondInv <= y) & (j > 1 | (y == 0 | firstInv <= y - 1)))
                            guess[y % l, mod(J(y + 1, i, true) - J(y, j, true) - y, N)] += weightJ(y + 1, i, true) * weightJ(y, j, true);
                    }
                }
            }

            return guess;
        }

        /** RETURNS MOST PROBABLE BYTES OF THE KEY */
        public int[] getFirstSuggestions(double[,] counter)
        {
            int[] guessedKey = new int[l];
            for (int i = 0; i < l; i++)
            {
                double maxWeight = -1;
                int maxWeightIndex = 0;

                for (int j = 0; j < N; j++)
                {
                    if (counter[i, j] > maxWeight)
                    {
                        maxWeight = counter[i, j];
                        maxWeightIndex = j;
                    }
                }
                guessedKey[i] = maxWeightIndex;

            }
            return guessedKey;
        }

        /** RETURNS MOST PROBABLE VALUES OF THE SUM OF ALL KEY BYTES */
        public int[] guessSumValue()
        {
            var sumGuess = new double[N];

            double[] wDiffL = Weights.getWeightsSumDiff(l);
            double[] wDiff2L = Weights.getWeightsSumDiff(2 * l);
            double[] wDiff3L = Weights.getWeightsSumDiff(3 * l);

            int index = l - 1;
            int iteration = 1;
            while (Weights.sumS[index] > prob_th)
            {
                if (S[index] >= index)
                {
                    int keySumSuggestion = mod(S[index] - (index + 1) * (index) / 2, N);
                    int guess = keySumSuggestion;
                    if (iteration > 1)
                        guess = FindDiv(keySumSuggestion, iteration); //returns -1 if false

                    if (guess > -1)
                        sumGuess[guess] += Weights.sumS[index];
                }
                index += l;
                iteration++;
            }/**/

            iteration = 1;
            index = l - 1;
            while (Weights.sumSS[index] > prob_th)
            {

                int keySumSuggestion = mod(S[S[index]] - (index + 1) * (index) / 2, N);
                int guess = keySumSuggestion;
                if (iteration > 1)
                    guess = FindDiv(keySumSuggestion, iteration);

                if (guess > -1)
                    sumGuess[guess] += Weights.sumSS[index];

                index += l;
                iteration++;
            }

            iteration = 1;
            index = l - 1;
            while (Weights.sumSSS[index] > prob_th)
            {
                int keySumSuggestion = mod(S[S[S[index]]] - (index + 1) * (index) / 2, N);
                int guess = keySumSuggestion;
                if (iteration > 1)
                    guess = FindDiv(keySumSuggestion, iteration);

                if (guess > -1)
                    sumGuess[guess] += Weights.sumSSS[index];

                index += l;
                iteration++;
            }/**/

            int i1 = 0;
            while (i1 + l < N & wDiffL[i1] > prob_th)
            {
                int i2 = i1 + l;
                int diffCi = mod(S[i2] - S[i1] - (i2) * (i2 + 1) / 2 + (i1) * (i1 + 1) / 2, N);

                if (S[i2] >= i2 && S[i1] >= i1)
                    sumGuess[diffCi] += wDiffL[i1];
                i1++;
            }/**/

            i1 = 0;
            while (i1 + 2 * l < N & wDiff2L[i1] > prob_th)
            {
                int i2 = i1 + 2 * l;

                int diffCi = mod(S[i2] - S[i1] - (i2) * (i2 + 1) / 2 + (i1) * (i1 + 1) / 2, N);

                if (diffCi % 2 == 0)
                {
                    if (S[i2] >= i2 && S[i1] >= i1)
                        sumGuess[diffCi / 2] += wDiff2L[i1];
                }
                i1++;
            }/**/

            i1 = 0;
            while (i1 + 3 * l < N & wDiff3L[i1] > prob_th)
            {
                int i2 = i1 + 3 * l;

                int diffCi = mod(S[i2] - S[i1] - (i2) * (i2 + 1) / 2 + (i1) * (i1 + 1) / 2, N);

                if (S[i2] >= i2 && S[i1] >= i1)
                {
                    int guess = 0;
                    while (mod(guess * 3, N) != diffCi & guess < N - 1)
                    {
                        guess++;
                    }
                    sumGuess[guess] += wDiff3L[i1];

                }
                i1++;
            }/**/

            int[] result = new int[Constants.sumAllKeyBytesDepth];
            double max = -1;
            int maxIndex = 0;

            for (int i = 0; i < Constants.sumAllKeyBytesDepth; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (sumGuess[j] > max)
                    {
                        max = sumGuess[j];
                        maxIndex = j;
                    }
                }
                sumGuess[maxIndex] = -1;
                result[i] = maxIndex;
            }
            return result;
        }

        /** FILLS ALL COUNTERS WITH DATA BASED ON PERMUTATION S */
        public void initializeCounters()
        {
            sCandidates = guessSumValue();
            keyJCounter = guessKeyBasedOnJs();
            initialCounter = new double[l, l, N];

            for (int i = 0; i < l; i++)
                for (int j = 0; j < N; j++)
                    initialCounter[i, i, j] = keyJCounter[i, j];


            for (int diff = 2; diff <= l; diff++)
            {
                double[] w = Weights.getWeightsSumDiff(diff);
                double[] wInv = Weights.getWeightsSumDiffInv(diff);
                for (int i1 = 0; i1 < N - diff; i1++)
                {
                    int i2 = i1 + diff;
                    int firstIndex = (i1 + 1) % l;
                    int secondIndex = i2 % l;

                    int value = mod(C[i2] - C[i1], N);
                    int valueInv = mod(InvC[i2] - InvC[i1], N);

                    //normalize
                    if (secondIndex < firstIndex)
                    {
                        firstIndex = (i2 + 1) % l;
                        secondIndex = i1 % l;
                        value = mod(sCandidates[0] - value);
                    }

                    if (w[i1] >= prob_th)
                    {
                        if (S[i2] >= i2 && S[i1] >= i1)
                        {
                            initialCounter[firstIndex, secondIndex, value] += w[i1];
                        }

                    }

                    if (wInv[i1] >= prob_th)
                    {
                        if (InvS[i2] <= i2 && InvS[i1] <= i1)
                        {
                            initialCounter[firstIndex, secondIndex, valueInv] += w[i1];
                        }

                    }

                }
            }
        }

        /** WITH FIXED s UPDATE COUNTERS */
        public double[,,] updateCounterWithAllSum()
        {
            double[,,] counter = Utils.copyArray3D(initialCounter, l, l, N);

            int lambda = 0; //number of s to be substraced (minus lambda*s)
            for (int i = 0; i < N; i++)
            {
                if (Weights.sumS[i] >= prob_th)
                    if (S[i] >= i)
                    {
                        int value = mod(C[i] - lambda * s, N);
                        counter[0, i % l, value] += Weights.sumS[i];
                    }

                if (Weights.sumSS[i] >= prob_th)
                {
                    int value = mod(S[S[i]] - i * (i + 1) / 2 - lambda * s, N);

                    counter[0, i % l, value] += Weights.sumSS[i];
                }/**/

                if (Weights.sumSS[i] >= prob_th)
                {
                    int value = mod(S[S[S[i]]] - i * (i + 1) / 2 - lambda * s, N);

                    counter[0, i % l, value] += Weights.sumSSS[i];
                }/**/

                if (i % l == l - 1) lambda++;
            }
            return counter;
        }

        /** GET CANDIDATES FOR KEY BYTES IN THE GROUP OF 4 BYTES */
        public void updateGroup(int startingPosition, int currentPosition, bool[] fixedPositions, int[] currentCandidates, List<int[]> suggestions)
        {

            int index = currentPosition;
            int maxPos = Math.Min(startingPosition + gl, l);

            //select next byte to fix
            while (index < maxPos)
            {
                if (fixedPositions[index])
                    index++;
                else
                    break;
            }
            //if the group is fixed, add key suggestion
            if (index >= maxPos) 
            {
                int[] key = new int[gl];
                for (int i = 0; i < gl; i++)
                {
                    if (i + startingPosition == maxPos) break;
                    key[i] = currentCandidates[i + startingPosition];
                }
                suggestions.Add(key);
            }
            else //update the byte weight and fix it
            {
                fixedPositions[index] = true;
                double[] counter = new double[N];
                int startIndex;
                int endIndex;

                findSumsUsedToUpdate(startingPosition, Math.Min(startingPosition + gl - 1, l - 1), index, fixedPositions, out startIndex, out endIndex);
                for (int k = startIndex; k <= index; k++)
                {
                    for (int l = index; l <= endIndex; l++)
                    {
                        for (int i = 0; i < N; i++)
                        {
                            int suggestion = i;
                            for (int other = k; other <= l; other++)
                            {
                                //subtract already fixed bytes in the sequence
                                if (other != index)
                                {
                                    suggestion = mod(suggestion - currentCandidates[other], N);
                                }
                            }
                            counter[suggestion] += currCounter[k, l, i];
                        }
                    }
                }

                int[] candidates = selectCandidatesForByte(counter, nc);

                for (int i = 0; i < nc; i++)
                {
                    currentCandidates[index] = candidates[i];
                    updateGroup(startingPosition, index, fixedPositions, currentCandidates, suggestions);
                }

                fixedPositions[index] = false; //for other instances on the stack
            }


        }


        /** TEST ALL CANDIDATES FOR THE KEY */
        public bool testKeys(int currGroup, int groupsCount, int[] testedKey, List<int[]>[] keyGroups)
        {
            if (currGroup == groupsCount)
            {
                if (testKey(testedKey))
                {
                    recoveredKey = testedKey;
                    return true;
                }
                return false;
            }

            bool found = false;
            for (int i = 0; i < keyGroups[currGroup].Count; i++)
            {
                for (int j = 0; j < Math.Min(gl, l - currGroup * gl); j++)
                {
                    testedKey[j + currGroup * gl] = keyGroups[currGroup][i][j];
                }
                if (testKeys(currGroup + 1, groupsCount, testedKey, keyGroups))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public bool testKey(int[] key)
        {
            bool same = true;
            for (int i = 0; i < l; i++)
            {
                //if (cipher.K[i] != key[i]) same = false;
            }

            return same;
        }


        /********************* TOOLS ********************/

        /**** GENERAL ******/
        protected void ConstructInvS()
        {
            InvS = new int[N];
            for (int k = 0; k < N; k++)
            {
                InvS[S[k]] = k;
            }
        }

        public void generateCombinations(int n, int k)
        {
            combinations(0, 0, k, new bool[n]);
        }

        public void combinations(int index, int filled, int limit, bool[] selection)
        {
            if (filled == limit)
            {
                bool[] combination = new bool[l];
                Array.Copy(selection, combination, l);
                allCombinations.Add(combination);
                return;
            }
            if (index == selection.Length)
                return;
            selection[index] = true;
            combinations(index + 1, filled + 1, limit, selection);
            selection[index] = false;
            combinations(index + 1, filled, limit, selection);
        }


        /** RETURNS value, WHICH SATISFIES value*times=result
        */
        public int FindDiv(int result, int times)
        {
            int guess = 0;
            while (mod(guess * times, N) != result)
            {
                guess++;
                if (guess == N)
                {
                    return -1;
                }
            }
            return guess;
        }

            /******** FOR j GUESSING **********/

        public int J(int round, int nesting, bool inverse)
        {
            if (round == 0) return 0;
            if (round > N || round < 0)
                return -1;

            switch (nesting)
            {
                case 2:
                    return (inverse) ? InvS[InvS[round - 1]] : S[S[round - 1]];
                case 3:
                    return (inverse) ? InvS[InvS[InvS[round - 1]]] : S[S[S[round - 1]]];
                case 4:
                    return (inverse) ? InvS[InvS[InvS[InvS[round - 1]]]] : S[S[S[S[round - 1]]]];
                default:
                    return (inverse) ? InvS[round - 1] : S[round - 1];
            }
        }

        public double weightJ(int round, int nesting, bool inverse)
        {
            if (round == 0) return 0;
            if (round > N || round < 0)
                return 0;
            double weight;
            switch (nesting)
            {
                case 2:
                    weight = (inverse) ? Weights.JInvSInvS[round - 1] : Weights.JSS[round - 1];
                    break;
                case 3:
                    weight = (inverse) ? Weights.JInvSInvSInvS[round - 1] : Weights.JSSS[round - 1];
                    break;
                case 4:
                    weight = (inverse) ? Weights.JInvSInvSInvSInvS[round - 1] : Weights.JSSSS[round - 1];
                    break;
                default:
                    weight = (inverse) ? Weights.JInvS[round - 1] : Weights.JS[round - 1];
                    break;
            }
            return weight;
        }

            /******** FOR SUM s ***********/

        public void findSumsUsedToUpdate(int from, int to, int position, bool[] fixedBytes, out int startIndex, out int endIndex)
        {
            startIndex = position;
            endIndex = position;

            while (startIndex > from && fixedBytes[startIndex])
                startIndex--;
            if (!fixedBytes[startIndex]) startIndex++;

            while (endIndex < to && fixedBytes[endIndex])
                endIndex++;
            if (!fixedBytes[endIndex]) endIndex--;
        }

            /** SELECT nc MOST PROBABLE CANDIDATES FOR BYTE WITH GIVEN counter */
        public int[] selectCandidatesForByte(double[] counter, int nc)
        {
            int[] candidates = new int[nc];

            List<KeyByteWeight> bytesWithWeights = new List<KeyByteWeight>();
            for (int i = 0; i < N; i++)
            {
                if (counter[i] > prob_th)
                {
                    bytesWithWeights.Add(new KeyByteWeight(i, counter[i]));
                }
            }
            bytesWithWeights.Sort(new KeyByteWeightComparer());

            for (int i = 0; i < Math.Min(bytesWithWeights.Count, nc); i++)
            {
                candidates[i] = bytesWithWeights[i].keyByte;
            }

            return candidates;
        }

        /********************* HELPERS *******************/

        protected int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        protected int mod(int x)
        {
            return mod(x, N);
        }

        protected void Swap(int[] S,int i, int j)
        {

            int tmp = S[i];
            S[i] = S[j];
            S[j] = tmp;
        }
    }
}
