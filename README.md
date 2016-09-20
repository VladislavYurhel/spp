# Лабораторные работы по СПП 3 курс 5 семестр
### Лабораторная работа 1
Написать собственный **Tracer**. На выходе должно быть два проекта:

**1.** Класс `Tracer`, который позволяет замерять время выполнения любых методов, сгенерировать XML-файл следующего содержания:
``` xml
<root>
  <thread id="1" time="105ms">
      <method name="external" time="100ms" package="core">
        <method name="internal" 
                time="200ms" 
                package="MyClass" 
                paramsCount="3"></method>
      </method>
  </thread>
</root>
```
— а также выводить дерево на консоль. Вложенные вызовы `StartTrace()` и `StopTrace()` должны влиять на вложенность элементов
в xml-дереве. У каждого элемента (метода) должны быть вычислены следующие атрибуты:
  + имя метода;
  + имя класса, которому метод принадлежит;
  + время выполнения метода;
  + количество параметров метода.
  
**2.** Проект с задержками, циклами и многопоточностью. В коде второго проекта должны содержаться вызовы
методов класса `Tracer`.

### Лабораторная работа 2
Разработать приложение на **WindowsForms** для отображения и редактирования результатов **лабораторной работы 1**.

Приложение должно отображать несколько табов (количество задается динамически, например, кнопкой-плюсиком), каждый таб позволяет 
выбрать файл xml (см. лаб. 1), который необходимо распарсить и представить в виде дерева *TreeView* (в скобках - атрибуты узлов).

```
- Thread (id=1, time=2000)
    - Method1 (Params=1, Package=MyClass, time=900)
        Method3 (Params=0, Package=MyClass, time=500)
        Method4 (Params=1, Package=MyClass, time=200)
    + Method2 (Params=2, Package=MyClass, time=1100)
```

По двойному клику на методе появляется форма редактирования атрибутов метода. При изменении времени выполнения метода
(атрибут ***time***) происходит пересчет времени выполнения потока.

Приложение должно позволять сохранять текущий файл либо сохранять изменения в новый файл. Вызов - 
в контекстном меню или строке меню приложения *(Файл - Сохранить как...)*. Открытие и сохранение - через строку меню.