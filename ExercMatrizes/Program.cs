namespace ExercMatrizes {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Insira a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Insira os valores da linha " + i + ": ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("=========================");
            List<int> principal = new List<int>();
            List<int> negativos = new List<int>();
            for (int x = 0; x < n; x++) {
                principal.Add(matriz[x, x]);
            }
            Console.WriteLine("Diagonal principal: ");
            foreach (int obj in principal) {
                Console.Write(obj + " ");
            }
            int sum = 0;
            Console.WriteLine(" ");
            for (int y = 0; y < n; y++) {
                for (int z = 0; z < n; z++) {
                    if (matriz[y, z] < 0) {
                        sum += 1;
                        negativos.Add(matriz[y, z]);
                    }
                }
            }
            Console.WriteLine("Números negativos: ");
            foreach (int obj in negativos) {
                Console.Write(obj + " ");
            }
            Console.WriteLine("Qtd de negativos: "+ sum);
        }
    }
}
