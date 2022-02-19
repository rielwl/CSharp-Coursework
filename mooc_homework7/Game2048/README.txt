阅读报告：
老师的代码使用了Button[]和数组来实现 （主要）

Form1_Load
在form显示之前的一些代码

StartGame
把界面设置好，要create两个号码

InitialUI
用于 GenerateAllButtons，也就是设置好全部的2048游戏4*4的板中的按钮
这里把buttons都生成好，位置都设置好，各种属性也在这里设置好
是直接用for循环，循环到全部的按钮，设置好
注意这里使用的GetTextOfButton和GetColorOfButton

RefreshUI
用RefreshAllButtons

RefreshAllButtons
用于换一下显示的按钮
与InitialUI不同的是这个不会再定义button，是直接改变button的颜色和text

GetTextOfButton
在一开始定义的gameMode就是在这里使用
之前老师定义了str1, str2, str3， 都是存不同游戏模式的Text，这里会先检查是哪个游戏模式
int n 是要查什么位置的button，然后返回的是n位置上的按钮的值对应的button text
button text是按着什么游戏模式+button值来决定的

GetColorOfButton
这个和GetTextOfButton相似，只是不需要查GameMode，只需要查button对应的值，然后返回对应的颜色

ProcessCmdKey
用于处理键盘上按left, right, up, down的结果
是在这里掌控游戏， 玩游戏
bMoved是个boolean，查是否有动，如果有动的话才需要改界面和查游戏是否结束
if(bMoved)... 用于处理做了一个可行的动作后需要刷新界面、查游戏是否结束等操作

rightMove, leftMove, upMove, downMove
都是用于实现四个方向的移动

generateNewData
用于随机产生数字， 先找空的位置，再在那里生成一个数字

IsGameOver
查游戏是否已经结束



所改的代码：
显示分数
加了一个显示分数的部分， 使用了老师定义的score

选择模式
使用了 radiobutton和 groupbox与一个submit按钮来实现了选择模式
模式有四种（数字、朝代、官职、军职)， 都是跟着老师定义的模式, 使用了gameMode
具体代码可以看btnSubmit_Click

记录高分功能
在Highscore.txt中记录最高分
逻辑就是一开始游戏(Form1_load)的时候会开Highscore.txt，查记录的highScore
然后再Form1_FormClosing的时候查score>highScore，若是就StreamWriter开起Highscore.txt，写入score
也在ProcessCmdKey中如果判断IsGameOver()为真，也查if(score>highScore)，
写入Highscore.txt和显示一个MessageBox，祝贺用户

其他方面的修改
修改了颜色，在GetColorOfButton中和Form1_Load中定义
写了加了用于玩游戏的按钮，在一个region里 (这个可能需要找一下开...，在ProcessCmdKey后)
也不难，跟着老师写的ProcessCmdKey，定义一个aftBtnCheck来查(老师在代码里写了这部分的逻辑)
然后加了四个按钮, btnUp_Click, btnDown_Click, btnLeft_Click, btnRight_Click