#  Описание архитектуры нейронной сети #
В этой работе была использована нейронная сеть, у которой свёрточная архитектура. На картинке можно увидеть, что с каждым разом размер матрицы данных уменьшается, что происходит благодаря операции свёртки, т.е. мы выбираем область, например двумерную матрицу в случае изображения, а потом домножаем на другую матрицу(ядро свёртки) и суммируем, а потом сдвигаем область вычислений. Такими операциями мы сокращаем размер каждой последующей матрицы. В итоге мы имеем, что область, которая больше похожа на искомые элементы имеет большее значение по сравнению с остальными.

![рисунок 1](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR0K4iQfVkQq2yavPNWppj0IHEZbsgW8cTmWA&usqp=CAU)

***inputs = tf.keras.Input(shape=(RESIZE_TO, RESIZE_TO, 3))*** - отвечает за входные данные и преобразует их к виду матрицы [None, 224, 224, 3].

В нашем случае мы добавляли слои (***"x = tf.keras.layers.Conv2D(filters=8, kernel_size=3)(inputs)"***). Эта команда создаёт матрицу для операции свёртки входных данных или матрицу свёртки. Сейчас немного про параметры:
1. ***filters=8*** - этот параметр отвечает за размерность выходного пространства.
2. ***kernel_size=3*** -этот параметр определяет размерность матрицы свёртки.

  ***x = tf.keras.layers.MaxPool2D()(x)*** - это операция разбивает входные данные на матрицы(по умолчанию 2х2), выбирает из них наибольшее и отправляет это значение на выход. В итоге размерность данных уменьшается вдвое.По умолчанию матрица размер 2х2.

  ***x = tf.keras.layers.Flatten()(x)*** - эта команда как бы превращает многомерные массивы в одномерный, образуя из данных одномерный тензор, объеденяя измерения, но при этом увеличивая размерность одного.
  
  ***outputs = tf.keras.layers.Dense(NUM_CLASSES, activation=tf.keras.activations.softmax)(x)*** - отвечает за результатю
  
  **Теперь о нашей задаче**
  
  *Визуализация метрики качества.*
  
  ![график 1.1](https://raw.githubusercontent.com/YurchenokMaxim/study/9bf91e516f59d889c52dbb18aaed12ca576950be/1epoch_categorical_accuracy.svg)
  
  *Функция потерь.*

  ![график 1.2](https://raw.githubusercontent.com/YurchenokMaxim/study/9bf91e516f59d889c52dbb18aaed12ca576950be/1epoch_loss.svg)
  
  ***Следующие графики были получены после изменения кода.***
  
  Оранжевая линия построена по обучению, а синяя - по валидации.
  
  *Визуализация метрики качества.*
   
  ![график 2.1](https://raw.githubusercontent.com/YurchenokMaxim/study/789e7442057b7a6faffbed202469aa2127f2f195/2epoch_categorical_accuracy.svg)
  
  *Функция потерь*
   
  ![график 2.2](https://raw.githubusercontent.com/YurchenokMaxim/study/789e7442057b7a6faffbed202469aa2127f2f195/2epoch_loss.svg)
  
  
  
  ***Анализ данных.***
  В ходе этой работы было произведено ознакомление с нейронными сетями свёрточного типа, а также общими принципами их функционирования. Также были добавлены некоторые новые слои, которые добавляют матрицы свёртки. Несмотря на увеличение их количества с одного до четырёх, значения на графиках тренировки изменились, но очень незначительно.
