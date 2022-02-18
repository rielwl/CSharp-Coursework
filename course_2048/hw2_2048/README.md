这次代码有点长，写一下README理解一下思路
细节就不讲了，但是讲一下各个函数的用处
主要是用了label来实现的

*board, changedBoard, changedVal, score, highScore*
board用于存储整个2048当前状态，是用二维数组实现
changedBoard是用于存储在各个函数中所改变的位置，是个bool的二维数组。
    写这个的思想是如果每次需要更新每个label可能会稍微慢点，所以只想更新所改的label
changedVal是用于存储这个数字是否已经和另一个数字merge过，也就是 *=2了吗？ 是个bool的二维数组
    写这个是为了在执行moveUp等函数，不能让一个数字一次性的*=2超过一次
    这是在测试的时候发现的一个bug，因为我使用的判断方式，有可能在某种情况下，比如2 2 4 会成为8
score与highScore都是int，用于存储score 和 最高score

*randomNum*
首先需要写一个randomNum来加数字 （可以加2或4，但是4的概率较低），这个需要注意的是更改changedBoard。
position的话我使用了1-16的位置来记住，这也是因为label的名字也跟着这个数字位子。(e.g. label1, label2...)

*resetChanged*
只是为了方便来吧changedBoard[i,j]和changedVal[i,j]的元素都设为false才写的函数
我还不是很理解C#，不知道有没有更方便的方式，例如c中的memset
这里不和resetBoard放在一起是因为每次执行完一个moveUp, moveDown都需要执行一次resetChanged

*boardFilled*
写这个函数视为了判断board满了吗

*resetBoard*
先把changedBoard[i,j]都设为true,这样可以标记下来，重新改每个label。board[i,j]也都设为0

*updateBoard*
用于更改labels，更改了两件事，labels的Text和颜色，注意把label的名字都留着label1, label2...的形式是为了这里能够直接this.Controls.Find()[0]。
颜色用：https://mycolor.space/ 与 https://coolors.co/ 来定的

*moveUp, moveDown, moveLeft, moveRight*
这个部分逻辑就不解释了，比较难解释，看代码就能理解
但是注意加入了flagCheck，且函数返回的是bool，这是因为如果按了一下，没有改什么，不应该执行randomNum，这里在KeyDown那里可以看到。
changedBoard和changedVal也要注意

*checkUp, checkDown, checkLeft, checkRight*
我和moveUp, moveDown, moveLeft, moveRight分开放的原因是因为moveUp, moveDown, moveLeft, moveRight找到可执行的动作后会执行，这里只需要查到两个相邻的数字是一样的就return true
应该有比较简单/快的，就是直接loop两次查每个数字的四周，不用用四个函数，但是我直接改写moveUp等函数实现这个

*gameNotEnded*
查游戏结束了吗，没结束就返回false

*Form1_KeyDown()*
这里处理按up, down, left, right的时候，和按R的时候要执行的代码。
这部分代码挺简单的

还有其他需要改进的地方，也会有我没发现的bug，但是这就是我实现的2048代码。