- ## Списки (lists)

В синтаксисе Markdown есть несколько видов списков. Для их оформления перед каждым пунктом нужно поставить подходящий тег и отделить его от текста пробелом.

### Нумерованные (ordered)  
Для создания нумерованного списка перед пунктами нужно поставить число с точкой. При этом нумерация в разметке ленивая. Неважно, какие именно числа вы напишете Markdown пронумерует список автоматически.

1. Первый пункт
2. Второй пункт
3. Третий пункт


1. Первый пункт
1. Второй пункт
1. Третий пункт


1. Первый пункт
73. Второй пункт
5. Третий пункт


Список можно начинать и не с единицы. Для нумерации важно только число, которое стоит перед первым пунктом.

27. Первый пункт
27. Второй пункт
27. Третий пункт


>       Обратите внимание, что между двумя нумерованными списками,идущими подряд, нужно оставить две пустые строки. 
>       Если оставить только одну, то Markdown воспримет два списка как один. 
>       Некоторые редакторы в таком случае увеличивают интервал между пунктами.

1. Первый пункт
2. Второй пункт
3. Третий пункт


1. Четвёртый пункт
2. Пятый пункт
3. Шестой пункт


### Ненумерованные (unordered)
Для создания ненумерованного списка нужно поставить перед каждым пунктом звёздочку *, дефис - или плюс +.

* Первый пункт
* Второй пункт
* Третий пункт
- Первый пункт
- Второй пункт
- Третий пункт
+ Первый пункт
+ Второй пункт
+ Третий пункт


Обратите внимание, что Markdown относит к разным спискам пункты, перед которыми стоят разные маркеры. Даже несмотря на то, что мы не оставляем пустых строк между списками.

Если же два списка идут подряд, а перед их пунктами стоят одинаковые маркеры, тогда между ними нужно отбить две пустые строки (как в случае с нумерованными списками).

### Чекбоксы (checkboxes)  
Чтобы сделать чекбоксы, нужно использовать маркированный список, но между маркером и текстом поставить [x] для отмеченного пункта и [] — для неотмеченного.

Чекбоксы доступны в диалекте GitHub Flavored Markdown (тот самый, который умеет зачёркивать текст) и поддерживаются не всеми редакторами Markdown. Например, нам для демонстрации примера пришлось открывать другой.


В PyCharm не работает затенение "\"  
\- [x] Отмеченный пункт  
\- [ ] Неотмеченный пункт  

В VSC не работают чекбоксы
- [x] Отмеченный пункт
- [ ] Неотмеченный пункт

В VSC не работает локальная ссылка
![Изображение](H:\Geek\geek-dz\Foto\pycharm_1.png)

![Изображение](https://github.com/PaSiK2605/Geek_dz/blob/1838f41b1498598304828436f6fa429aa00f7355/pycharm_1.png)
