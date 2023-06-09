# Итоговое домашнее задание Блок 1.

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Задача:** 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Блок-схема**

![Блок-схема](Block1_final.jpg)

**Решение:**

1. Запрашиваем у пользователя количество элементов в массиве
2. Создаем массив заданного размера
3. Вводим счетчик для элементов подходящих по условию задачи (не более 3 символов)
4. Запрашиваем ввод элементов массива у пользователя, если введенная строка <= 3 символам увеличиваем счетчик на 1
5. Создаем итоговый массив размерностью равной счетчику
6. В цикле проверяем все элементы массива введенного пользователем на количество символов, если их не больше трех переносим элемент в итоговый массив
7. Выводим стартовый и итоговый массив

-------------------------------
Если массив задан изначально меняем пункт 4 на:

4. В цикле проверяем элементы массива на количество символов, если их не больше трех увеличиваем счетчик на 1