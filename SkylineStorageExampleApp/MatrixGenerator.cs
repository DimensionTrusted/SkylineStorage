using System;

namespace SkylineStorageExampleApp
{
    public sealed class MatrixGenerator
    {
        public void GenerateDanceMatrix()
        {
            GenerateMainDiagonal();
            GenerateLeftBottomTriangle();
            GenerateRightTopTriangle();
            Print();
        }

        private void GenerateMainDiagonal()
        {
            for (int i = 0; i < Size; i++)
            {
                MainDiagonal[i] = Rand.Next(1, 10);
            }

            Shake(MainDiagonal);
        }

        private void GenerateLeftBottomTriangle()
        {
            for (int i = 0; i < Threshold; i++)
            {
                LeftBottomTriangle[i] = Rand.Next(0, 10);
            }

            for (int i = Threshold; i < LeftBottomTriangle.Length; i++)
            {
                LeftBottomTriangle[i] = 0;
            }

            Shake(LeftBottomTriangle);
        }

        private void GenerateRightTopTriangle()
        {
            for (int i = 0; i < Threshold; i++)
            {
                RightTopTriangle[i] = Rand.Next(0, 10);
            }

            for (int i = Threshold; i < RightTopTriangle.Length; i++)
            {
                RightTopTriangle[i] = 0;
            }

            Shake(RightTopTriangle);
        }

        private void Shake(int[] GeneratedPart)
        {
            for (int i = GeneratedPart.Length - 1; i >= 0; i--)
            {
                int j = Rand.Next(i);
                var temp = GeneratedPart[i];
                GeneratedPart[i] = GeneratedPart[j];
                GeneratedPart[j] = temp;
            }
        }

        private void Print()
        {
            for (int i= 0; i < MainDiagonal.Length; i++)
            {
                Console.Write(MainDiagonal[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < LeftBottomTriangle.Length; i++)
            {
                Console.Write(LeftBottomTriangle[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < RightTopTriangle.Length; i++)
            {
                Console.Write(RightTopTriangle[i] + " ");
            }
            Console.WriteLine();
        }

        public int[] MainDiagonal = new int[Size];
        public int[] LeftBottomTriangle = new int[((int)Math.Pow(Size, 2) - Size) / 2];
        public int[] RightTopTriangle = new int[((int)Math.Pow(Size, 2) - Size) / 2];
        private readonly static Random Rand = new Random();
        private readonly static int Size = Rand.Next(5, 10);
        private readonly static int Threshold = Rand.Next(0, ((int)Math.Pow(Size, 2) - Size) / 4);
    }
}
