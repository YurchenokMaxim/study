#  Описание архитектуры нейронной сети #
В этой работе была использована нейронная сеть, у которой свёрточная архитектура. На картинке можно увидеть, что с каждым разом размер матрицы данных уменьшается, что происходит благодаря операции свёртки, т.е. мы выбираем, например двумерную матрицу в случае изображения, область, а потом домножаем на другую матрицу(ядро свёртки) и суммируем, а потом сдвигаем область вычислений. Такими операциями мы сокращаем размер каждой последующей матрицы. В итоге мы имеем, что область, которая больше похожа на искомые элементы имеет большее значение по сравнению с остальными.

![рисунок 1](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR0K4iQfVkQq2yavPNWppj0IHEZbsgW8cTmWA&usqp=CAU)

В нашем случае мы добавляли слои (***"x = tf.keras.layers.Conv2D(filters=8, kernel_size=3)(inputs)"***). Эта команда создаёт матрицу для операции свёртки входных данных или матрицу свёртки. Сейчас немного про параметры:
1. ***filters=8*** - этот параметр отвечает за размерность выходного пространства.
2. ***kernel_size=3*** -этот параметр определяет размерность свёртки.

  ***x = tf.keras.layers.MaxPool2D()(x)*** - это операция максимального объединения или уменьшает выборку входного представления, принимая максимальное значение в окне.

  ***x = tf.keras.layers.Flatten()(x)*** - эта команда как бы превращает многомерные массивы в одномерный, образуя из данных одномерный тензор, объеденяя измерения, но при этом увеличивая размерность одного.
  
  **Теперь о нашей задаче**
  
  Эти графики были получены при обучении исходной нейронной сети без изменений.
  
  ![график 1.1](https://raw.githubusercontent.com/YurchenokMaxim/study/9bf91e516f59d889c52dbb18aaed12ca576950be/1epoch_categorical_accuracy.svg)

  ![график 1.2](https://raw.githubusercontent.com/YurchenokMaxim/study/9bf91e516f59d889c52dbb18aaed12ca576950be/1epoch_loss.svg)
  
   Эти графики были получены при обучении нейронной сети после добавления слоёв.
   
  ![график 2.1](https://raw.githubusercontent.com/YurchenokMaxim/study/789e7442057b7a6faffbed202469aa2127f2f195/2epoch_categorical_accuracy.svg)
   
  ![график 2.2](https://raw.githubusercontent.com/YurchenokMaxim/study/789e7442057b7a6faffbed202469aa2127f2f195/2epoch_loss.svg)
  
  Оранжевая линия построена по логам train, а синяя - по логам validation.
  
  ***Анализ данных***
  В ходе этой работы было произведено ознакомление с нейронными сетями свёрточного типа, а также общими принципами их функционирования. Также были добавлен некоторе нове слои, которые добавляют матрицы свёртки. Несмотря на увеличение их количества с одного, до 4ёх, значения на графиках тренировки изменились примерно в 1.1- 1.2 раза. По моим предположениям от этого итоги не сильно изменились.
