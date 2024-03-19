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

        public Sequence(List<int> numbers)
        {
            Numbers = numbers;
        }

        // Checks if the sequence is strictly increasing
        public static bool IsIncreasing(List<int> sequence)
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
        public static bool IsDescending(List<int> sequence)
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
        public static bool IsNonIncreasing(List<int> sequence)
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

        // Checks if the sequence is an arithmetic progression
        public static bool IsArithmeticProgression(List<int> sequence)
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
        public static bool IsGeometricProgression(List<int> sequence)
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


        // Deserialization method
        public static Sequence LoadFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Sequence>(json);
        }

    }
}