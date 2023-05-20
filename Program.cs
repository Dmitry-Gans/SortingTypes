// Сортировка выбором
// Способ с использованием Классов, которые же сами и создали

using static Sorting; // Класс сортировки
using static Infrastructure; // Класс создания и показа массива

// int[] array = CreateArray(10);
// Show(array);
// SortSelection(array);
// Show(array);

10.CreateArray(min: 10, max: 20) // Теперь можем сами задавать значения через двоеточие
  .Show("/") // Теперь можем задавать знак разделителя поместив его в ковычки 
  .SortSelection()
  .Show("-");