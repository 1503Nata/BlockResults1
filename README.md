void start(string [] arrayStart) -  метод для создания первоначального массива из строк.
string [] end(string [] arrayStart) - метод для подсчета элементов массива с количеством знаков менее или равно 3.
string [] arrayEnd = new string [count] - создаем новый массив из отсортированных элементов.
arrayEnd[j] = arrayStart[i] - присваивает отсортированные значения массива.
void printArray(string [] arrayStart) - метод для вывода массива на консоль.
start(arrayStart) - вызов метода формирования первоначального массива.
printArray(end(arrayStart)) - вызов метода вывода на консоль отсортированного массива.