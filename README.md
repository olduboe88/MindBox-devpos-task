# Тестовое задание Mindbox на позицию С# разработчика

Вопрос №1

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

Примечание: я не смог выполнить вычисление площади фигуры без знания типа фигуры:
* Сначала я думал, что можно сделать определение типа фигуры между кругом и треугольником, но т.к. для разных фигур требуются разные параметры, необходимо задавать параметры, зная, для какой формулы они используются - следовательно, целевая фигура известна с самого начала и необходимость такой функциональности отпадает;
* Если мы хотим дать определение любой фигуре при помощи формулы, мы можем использовать формулу для нахождения площади многоугольника, однако ЛЮБАЯ фигура подразумевает не только фигуры с определенным количеством углов: это может быть круг или вообще неровная фигура;
* Найти площадь любой фигуры можно найти при помощи определенного интеграла.

Вопрос №2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

По возможности — положите ответ рядом с кодом из первого вопроса.
