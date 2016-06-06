# KISSlicerPlugin
KISSlicerPlugin plugin for Repetier Host

[KISSlicerPlugin.1.0.2.dll](https://github.com/vassav/KISSlicerPlugin/blob/master/Bins/KISSlicerPlugin.1.0.2.zip)

1. Содержимое архива распаковать в папку [Repetier-Host]\plugins\KISSlicerPlugin
2. В настройках слайсера указать путь к KISSlicer.
3. Так же можно указать имя выходного файла gcode (по умолчанию composition.gcode, в него же нужно будет сохранять gcod из киса).

Далее все просто, в репитер загружаем модель, выбираем слайсер KISSlicer.
При нажатии на кнопку "Слайсинг" будет произведен слайсинг модели с использованием последних наскроек KISSlicer.

По кнопке "Start KISSlicer" запускается KISSlicer с нашей моделью. Слайсим ее и сохраняем gcod в файл указанный в п.3.
После чего полученный gcod отобразится в репитере.

P.S. Если не закрывать кисс, и повторно в нем отслайсить и сохранить модель - то она обновится и в репитере

[Обсуждение установки плагина под Windows](https://github.com/vassav/KISSlicerPlugin/issues/1)
