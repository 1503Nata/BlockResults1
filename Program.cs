Console.Write("Количество элементов массива =  ");
int size = Convert.ToInt32(Console.ReadLine());
string [] arrayStart = new string [size];
void start(string [] arrayStart)
{
  for (int i = 0;i<arrayStart.Length;i++)
  {
     Console.Write($"Элемент № {i+1} - ");
     arrayStart[i] = Console.ReadLine();
  }
}
string [] end(string [] arrayStart)
{
  int count = 0;
  for (int i = 0;i<arrayStart.Length;i++)
  {
    if(arrayStart[i].Length <=3)
    count++;
  }
  string [] arrayEnd = new string [count];
  int j = 0;
  for (int i=0;i<arrayStart.Length;i++)
  {
    if(arrayStart[i].Length<=3)
    {
        arrayEnd[j] = arrayStart[i];
        j++;
    }
  }
  return arrayEnd;
}
void printArray(string [] arrayStart)
{
    Console.Write($"Массив из строк, длина которых меньше или равна 3 символа : [");
    for (int i = 0;i<arrayStart.Length;i++)
    {
    Console.Write($" {arrayStart[i]}, ");
    }
    Console.Write("]");
}
start(arrayStart);

printArray(end(arrayStart));