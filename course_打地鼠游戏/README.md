# 重构打地鼠游戏
## 改的变量名：
没有换pictureBox的名字因为觉得这25个pictureBox在这个程序中的名字挺适合的，不难理解，且数字可以很容易地用来代表picturebox的位置
label5 -> labelStart
label3 -> labelLevel
label2 -> labelHitTimes
label4 -> labelExit
i1 -> RandomBox
i2 -> HitTimes
timer1 -> timerMoleAppear
timer2 -> timerMoleReturn
bian -> changed
timerMoleAppear_Tick: i -> rnd


## 写了函数:
为了labelStart_Click没有那么多重复程序，且为了增加程序的可维护性写了一下上个函数
SetTimers(int x) // 设置timer的interval
StartTimers() // 开始计时
StopTimers() // 停止计时

写了一下函数是为了在pictureBox MouseDown的时候不用一直重复代码
这样也容易维护
在MoleClicked也加了try-catch的异常处理。
MoleClicked(int BoxNumber)



