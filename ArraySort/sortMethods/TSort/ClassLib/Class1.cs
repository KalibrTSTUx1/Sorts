using System.Drawing;
using System.Text;

namespace TSortLib
{
    /// <summary>
    /// Класс, создающий объект - граф и позволяющий осуществлять топологическую его сортировку
    /// </summary>
    public class Graph
    {
        private int[,] matrixAdj;
        private List<int[]>[] listAdj;
        private List<int[]> edgeList;
        private int[] sortedGraph;
        private bool cycledGraph;
        private const int INF = 1000000;
        enum Color { White, Gray, Black };
        /// <summary>
        /// Конструктор класса, создающий его экземпляр на основе матрицы смежности
        /// </summary>
        /// <param name="matrixAdj">Матрица смежности графа в виде двумерного массива</param>
        public Graph(int[,] matrixAdj)
        {
            this.matrixAdj = matrixAdj;
        }
        /// <summary>
        /// Геттер, возвращающий граф в виде матрицы смежности
        /// </summary>
        /// <returns>Граф в виде двумерного массива - матрицы смежности</returns>
        public int[,] getMatrixAdj()
        {
            return this.matrixAdj;
        }
        /// <summary>
        /// Геттер, возвращающий граф в виде списка смежности
        /// </summary>
        /// <returns>
        /// Граф в виде списка смежности - 
        /// массива списков массивов
        /// </returns>
        public List<int[]>[] getListAdj()
        {
            this.listAdj = ConvertToListAdj(matrixAdj);
            return this.listAdj;
        }
        /// <summary>
        /// Геттер, возвращающий граф в виде списка ребер
        /// </summary>
        /// <returns>Граф в виде списка ребер - списка массивов</returns>
        public List<int[]> getEdgeList()
        {
            this.edgeList = ConvertToEgdeList(matrixAdj);
            return this.edgeList;
        }
        /// <summary>
        /// Геттер, возвращающий отсортированный топологически граф
        /// </summary>
        /// <returns>Целочисленный массив, содержащий 
        /// последовательность вершин при топологической сортировке
        /// либо null, если сортировка невозможна</returns>
        public int[] getSortedGraph()
        {
            if (!isCycledGraph())
            {
                sortedGraph = TopSort(getMatrixAdj());
                return sortedGraph;
            }
            return null;
        }
        /// <summary>
        /// Геттер, который дает информацию о наличии циклов в графе
        /// </summary>
        /// <returns>
        /// True, если в графе есть циклы,
        /// False, если нет
        ///</returns>
        public bool isCycledGraph()
        {
            this.cycledGraph = IsCycled(matrixAdj);
            return this.cycledGraph;
        }
        /// <summary>
        /// Функция, конвертирующая граф из матрицы смежности в список смежности
        /// </summary>
        /// <param name="mAdj">Граф в виде двумерного массива - матрицы смежности</param>
        /// <returns>
        /// Граф в виде списка смежности - 
        /// массива списков массивов
        /// </returns>
        private List<int[]>[] ConvertToListAdj(int[,] mAdj)
        {
            int n = mAdj.GetLength(0);
            List<int[]>[] AdjacencyLists = new List<int[]>[n];
            for (int i = 0; i < n; ++i)
            {
                AdjacencyLists[i] = new List<int[]>();
                for (int j = 0; j < n; ++j)
                    if (mAdj[i, j] < 100000)
                        AdjacencyLists[i].Add(new int[] { j, mAdj[i, j] });
            }
            return AdjacencyLists;
        }
        /// <summary>
        /// Функция, конвертирующая граф из матрицы смежности в список ребер
        /// </summary>
        /// <param name="mAdj">Граф в виде двумерного массива - матрицы смежности</param>
        /// <returns>Граф в виде списка ребер - списка массивов</returns>
        private List<int[]> ConvertToEgdeList(int[,] mAdj)
        {
            int n = mAdj.GetLength(0);
            List<int[]> Edges = new List<int[]>();
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    if (mAdj[i, j] < 100000)
                        Edges.Add(new int[] { i, j, mAdj[i, j] });
                }
            return Edges;
        }
        /// <summary>
        /// Функция, проверяющая граф на зациклованность
        /// </summary>
        /// <param name="edgeList">Граф в виде - </param>
        /// <returns>
        /// True, если в графе есть циклы,
        /// False, если их нет
        /// </returns>
        private bool IsCycled(int[,] m)
        {
            int n = m.GetLength(0);
            int[] Order = new int[n];
            Color[] Colors = new Color[n];
            int key = n;
            bool success = false;
            for (int i = 0; i < n; ++i) //красим все вершины в белый
                Colors[i] = Color.White;
            for (int i = 0; i < n; ++i) // проходимся по соседям начальной вершины
                if (Colors[i] == Color.White)
                    Dfs(m, n, i, ref Colors, ref success);
            bool flagi = success;
            return flagi;
        }
        static void Dfs(int[,] m, int n, int v, ref Color[] cycle, ref bool success)
        {
            if (success)
                return;
            cycle[v] = Color.Gray; //красим текущую вершину
            for (int i = 0; i < n; ++i) // проходим по соседям вершины
                if (v != i && m[v, i] != 0) // проверяем на наличие ребра
                    if (cycle[i] == Color.White)
                        Dfs(m, n, i, ref cycle, ref success); // идем к новой вершине (в которой не были)
                    else if (cycle[i] == Color.Gray) // если же можно пойти в вершину в которой были
                    {
                        success = true; // есть цикл
                        return;
                    }
            cycle[v] = Color.Black;
        }
        /// <summary>
        /// Функция, осуществляющая топологическую сортировку данного графа,
        /// представленного в виде матрицы смежности
        /// </summary>
        /// <param name="M">Граф в виде двумерного массива - матрицы смежности</param>
        /// <returns>Массив чисел, показывающий порядок вершин отсортированного графа</returns>
        public static int[] TopSort(int[,] M)
        {
            int N = M.GetLength(0);
            int[] Order = new int[N];
            Color[] Colors = new Color[N];
            for (int i = 0; i < N; ++i)
                Colors[i] = Color.White;
            int Key = N;
            bool Success = true;
            for (int i = 0; i < N; ++i)
                if (Success && Colors[i] == Color.White)
                    DFS(M, i, ref Colors, ref Order, ref Key, ref Success);
            return Order;
        }
        /// <summary>
        /// Вспомогательный метод, который осуществляет алгоритм закрашивания вершин 
        /// для обозначения их достижимости.
        /// принимающий целочисленный код ASCII символа v текущей вершины, 
        /// массив цветов вершин (Colors), 
        /// массив целых чисел - порядковых номеров вершин (Order),
        /// целое число - текущее значение порядкового номера вершины (Key),
        /// boolевую переменную, которая является 
        /// признаком успешного продолжения алгоритма (Success).
        /// </summary>
        /// <param name="M"></param>
        /// <param name="v"></param>
        /// <param name="Colors"></param>
        /// <param name="Order"></param>
        /// <param name="Key"></param>
        /// <param name="Success"></param>
        private static void DFS(int[,] M, int v, ref Color[] Colors, ref int[] Order, ref int Key, ref bool Success)
        {
            int N = M.GetLength(0);
            Colors[v] = Color.Gray;
            for (int i = 0; i < N; ++i)
                if (v != i && M[v, i] != 0)
                    if (Colors[i] == Color.White)
                        DFS(M, i, ref Colors, ref Order, ref Key, ref Success);
                    else if (Colors[i] == Color.Gray)
                    {
                        Success = false;
                        break;
                    }
            if (!Success)
                return;
            Colors[v] = Color.Black;
            Order[v] = Key;
            Key--;
        }
        

    }
}