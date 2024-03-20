using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SequenceAnalysis
{
    public class Sequence
    {
        public List<int> Numbers { get; set; }
        public List<List<int>> SubSequences { get; set; }

        public Sequence(List<int> numbers)
        {
            Numbers = numbers;
            SubSequences = new List<List<int>>();
        }

        // Checks if the sequence is strictly increasing
        public bool IsIncreasing(List<int> sequence)
        {
            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] <= sequence[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        // Checks if the sequence is strictly decreasing
        public bool IsDescending(List<int> sequence)
        {
            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] >= sequence[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        // Checks if the sequence is non-increasing (monotonically decreasing)
        public bool IsNonIncreasing(List<int> sequence)
        {
            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] > sequence[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        // Checks if the sequence is non-decreasing (monotonically increasing)
        public bool IsNonDecreasing(List<int> sequence)
        {
            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] <= sequence[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        // Checks if the sequence is an arithmetic progression
        public bool IsArithmeticProgression(List<int> sequence)
        {
            if (sequence.Count < 2) return false;

            int difference = sequence[1] - sequence[0];
            for (int i = 2; i < sequence.Count; i++)
            {
                if (sequence[i] - sequence[i - 1] != difference)
                {
                    return false;
                }
            }
            return true;
        }

        // Checks if the sequence is a geometric progression
        public bool IsGeometricProgression(List<int> sequence)
        {
            if (sequence.Count < 2 || sequence.Contains(0)) return false;

            double ratio = (double)sequence[1] / sequence[0];
            for (int i = 2; i < sequence.Count; i++)
            {
                if ((double)sequence[i] / sequence[i - 1] != ratio)
                {
                    return false;
                }
            }
            return true;
        }

        public List<string> GetTypeOfSequence()
        {
            List<string> types = new List<string>();
            if (IsIncreasing(Numbers))
            {
                types.Add("Increasing");
            }
            if (IsDescending(Numbers))
            {
                types.Add("Decreasing");
            }
            if (IsNonIncreasing(Numbers))
            {
                types.Add("Non-Increasing");
            }
            if (IsNonDecreasing(Numbers))
            {
                types.Add("Non-Decreasing");
            }
            if (IsArithmeticProgression(Numbers))
            {
                types.Add("Arithmetic Progression");
            }
            if (IsGeometricProgression(Numbers))
            {
                types.Add("Geometric Progression");
            }
            else if (types.Count == 0)
            {
                types.Add("Unknown");
            }
            return types;
        }

        // find max element
        public int Max()
        {
            return Numbers.Max();
        }

        // find min element
        public int Min()
        {
            return Numbers.Min();
        }

        // find whether element belongs to the given sequence
        public bool ElementBelongs(int element)
        {
            return Numbers.Contains(element);
        }

        // compares two sequences
        public bool CompareSequences(Sequence sequence_2)
        {
            var firstNotSecond = Numbers.Except(sequence_2.Numbers).ToList();
            var secondNotFirst = sequence_2.Numbers.Except(Numbers).ToList();
            return !firstNotSecond.Any() && !secondNotFirst.Any();
        }

        public List<List<int>> GetLocalExtremes(bool maxima)
        {
            SubSequences.Clear(); // Clear previous subsequences

            if (Numbers.Count < 3) // If the sequence is too short to have a local extreme
            {
                if (Numbers.Count > 0) // If there are elements, add them as a single subsequence
                {
                    SubSequences.Add(new List<int>(Numbers));
                }
                return SubSequences;
            }

            List<int> currentSubSequence = new List<int> { Numbers[0] }; // Start with the first element

            for (int i = 1; i < Numbers.Count - 1; i++)
            {
                // Add the current number to the current subsequence
                currentSubSequence.Add(Numbers[i]);

                // Check for local maxima or minima
                if ((maxima && Numbers[i] > Numbers[i - 1] && Numbers[i] > Numbers[i + 1]) ||
                    (!maxima && Numbers[i] < Numbers[i - 1] && Numbers[i] < Numbers[i + 1]))
                {
                    // Since we're at a local extreme, also add the next element before splitting

                    // Save the current subsequence to SubSequences
                    SubSequences.Add(new List<int>(currentSubSequence));

                    // Start a new subsequence with the element after the local extreme
                    currentSubSequence = new List<int>();

                    // If the next element is not the last one, add it to the new subsequence
                    if (i + 1 < Numbers.Count)
                    {
                        currentSubSequence.Add(Numbers[i]);
                    }
                }
            }

            // Add the last element if it hasn't been included yet
            if (!currentSubSequence.Contains(Numbers[^1]))
            {
                currentSubSequence.Add(Numbers[^1]);
            }

            // Ensure we don't add an empty subsequence
            if (currentSubSequence.Count > 0)
            {
                SubSequences.Add(new List<int>(currentSubSequence));
            }

            return SubSequences;
        }

        public List<int> LargestSubsequence()
        {
            List<int> ints = new List<int>();
            foreach (List<int> list in SubSequences)
            {
                ints.Add(list.Sum());
            }

            return SubSequences[ints.IndexOf(ints.Max())];
        }

        public void WriteSequence()
        {
            foreach (int num in Numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public void WriteSubSequences()
        {
            foreach (List<int> subsequence in SubSequences)
            {
                foreach (int num in subsequence)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        // Serialization method
        public void SaveToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(filePath, json);
        }

        // Deserialization method
        public Sequence LoadFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Sequence>(json);
        }

    }
}