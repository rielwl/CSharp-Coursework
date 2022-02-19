*这是一个简单的ATM Console app*
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#新版本所改变的地方
*1)改进的地方*
改进了console，本来不是很喜欢黑背景的console，就在Program.cs改了Console.BackgroundColor 和 Console.ForegroundColor，一定一定要加入Console.Clear()才能把整个背景变成白色
在Program.cs用ReadKey()实现一个在结束transaction后可以按esc就能直接结束所有transaction
- 但这也使得每当一个transaction完毕后，console并不会自动弹出下一个transaction，因为它在ReadKey(需先按任何一个按钮)
- 本来用的是for(int i=0; i<5; i++)，transaction 5次后自动结束
再读一遍代码的时候发现忘了使用closeAccount，因此在Program.cs加了一个关闭账号的功能
最后也加了一个displayTransactions的功能 (Account.cs加一个List)，为的是可以让用户display所有过去的withdraw和deposit
除此之外也做了细微改变，改了一下代码，让它更简洁易读

*2)程序中使用时间及委托*
实现了BigMoneyFetched (跟着mooc上的要求)，这里在BigMoneyArgs.cs 加了BigMoneyWithdrawn()，在ATM.cs加BigMoneyFunc()
委托在ATM.cs中用来定义msg, msgTwoLines, msgThreeLines，（顺便也用了lambda来实现)，这是为了把Console.WriteLine部分弄得比较简洁。我的代码使用了很多Console.WriteLine，有很多是连着几行，本来想用\n来分，但是觉得加一个msgTwoLines, msgThreeLines，可能读起代码就容易些

*3)程序中使用自定义异常*
在BadCashException实现了异常，且在ATM.cs实现了badCashCheck函数，这个思路是跟着教学网上的提议写的

*4)使用其他语法*
这里使用了lambda表达式，在ATM.cs中加的，和委托的部分链接起来，一起用
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#旧版本 readme, 可以参考一下了解代码

*Account.cs*
写的是账号的程序
这不和真实的银行一样，这里假设normal bank account可以欠债，就是可以取出多于已经在账号得钱。这会产生一个debt。
除此之外就有一个account number, 一个 password， 和账号中的money.
accntBalance, accntName, accntPwd 都用了get和set.
withdrawMoney和depositMoney定义为virtual，这样过后可以做覆盖.

*savingsAccount.cs*
使用继承来创建一个savingsAccount, savingsAccount: Account
savingsAccount有一个利率，在savingPlans中定义了两个enum，用来存savingsAccount的一些内容
我把savingsAccount的思路写成在开savings account时需要考虑利率，有三种savings account，可以看savingPlans.cs
这里定义了一个checkPlan, 因为三种savings account有个别的利率，且有一个minAmt，要开一个savings account就需要存储一定的钱，如果不够钱，就不能开那个账号
所以每个账号都定义了一个利率和minAmt
过后可以算第二年加入利率后账号中的钱
然后覆盖了depositMoney和withdrawMoney，因为savingsAccount没有debt，且需要一定的钱才能继续开着

*savingsPlan.cs*
用了枚举
两个enum: savingPlansInterest（记录利率）, 和savingPlansMin (记录账号中需要存的钱)
有三种savings plan, lowCost, midCost 和 highCost
按照账号type，可以取出相应的利率和需要存储的钱

*Bank.cs*
定义了两个list，一个存savings account，一个存normal account
这里定义了openAccount, closeAccount和findAccount

*ATM.cs*
定义了Transaction()，这个函数用于定义每个transaction的逻辑，用了很多if-else和switch
代码很长，但是思路就是先查用户是想开账号还是在已存在的账号中做交易
先处理已存在的账号(process == "1")，然后问用户开的账号是savings account还是normal bank account
过后输入account number 和 password，就分情况处理，也不解释了，可以看代码中Console.WriteLine，可以用它来理解代码
过后处理开账号(process == "2")，也需要先分是savings account还是normal account，然后问用户的account number 和 password要设为什么
直接读入所需要读的内容，（注意savings account还需要定义时哪种)，过后就可以开账号了
开完就可以在下个transaction使用了

*Program.cs*
这是main
这里定义了四个账号，两个normal bank account，两个savings account。
transaction只跑5次，这个可以换成10次etc.
**normal bank account 1**
account number: 1234
password: 1234
money: 100
**normal bank account 2**
account number: 4321
password: 4321
money: 500
**savings account 1**
account number: 123
password: 123
money: 1000
savings type: low cost low interest
**savings account 2**
account number: 321
password: 321
money: 2000
savings type: mid cost mid interest