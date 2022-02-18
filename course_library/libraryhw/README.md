
这次的代码写得有点赶，没有好好计划好代码使得代码非常乱，也加了太多classes，
没有估计耗时间，使得最后的效果没那么好，代码也很不简洁。
这也可能会有bugs，因为是在有很多小细节。
这里写了一个readme， 有两部分，怎么使用和代码介绍。
可能思路有点乱，尽量不讲细节，细节可以看代码。


# 怎么使用
首先，右上角有一个Account Type，可以选一下Normal User或High Level User
High Level User可以借Protected Books 和 Normal Books, 但是Normal User只能借Normal Books。
借书量: Normal User 是3本， High Level User 是5本
已经有一些可以使用的账号  (注意Username需要完全一样，就是大字母或是小字母)：
Normal User:
Username: Jane  Password：123
Username: Mary  Password: 321
Username: Tom   Password: 111
Username: Jack  Password: 222
Username: Sam   Password: 333
也可以再右下角按Create New Account，输入Username和password即可。
登入后会弹出另一个Form, 左边两个Textbox是写着Normal Books和 Protected Books，都是图书馆有的书
右上角的Textbox是当前用户已经借的书(Books Currently Borrowed)
旁边的Textbox (Books to Return)是用于还已经借到的书，直接输入书名键盘上按Enter就行。
先在Book to Place in Checkout Counter输入要借的书名，再输入Enter，这书会进入Checkout Counter，
过后按下面的Checkout Book，每按一次就可以借到一本在Checkout Counter中的书
但是在按Checkout Book时，有机会出现System Fail，把用户退出去
左下角是Delete Account，把用户的账号删了



# 代码介绍
事件和委托在Form1.cs的failedLogin用
Form2.cs btnCheckout.Click也用了事件，也用了一个random号码，有可能按Checkout按钮时会把用户退出
try-catch异常在Form2.cs中被用到了：systemFailCheck用于实现异常


## txt文件介绍
UserAccounts.txt用于记录每个账号，记录用户的username, password，最后一个数字是那个用户是1(normal user)或是2(high level user)
BorrowedBooksHighLevel.txt和BorrowedBooksNormal.txt用于记录每个user借的书，第一个数字是那位user借了几本书，过后每本书有两个数字用来定义书，一个是书的ID，一个是书的种类(protected还是normal)
NormalBooks.txt和ProtectedBooks.txt用来定义书的名字和每本书有几个

## basicUser
basicUser是用于让highLevelUser继承的父类
**定义了:** 
username, password, booksBorrowed, userStatus //userStatus记录是不是normal user还是high level
booksBorrowedID, bookType //这两个是List，记录所借到的书的ID和个别书的类
待会儿再其他函数中会看到我用了两个List, 一个记录protected books，一个记录normal books
这两个顺序不会改，因此把书在个别list中的位置记录为ID，借书的时候记录了ID而不是名字，而因为有两个list,id会重复，再记录了一个bookType list，记录的是那书是protected book还是normal book
*函数*
basicUser(username, password, userStatus): userStatus 1 是normal user, 2是high level user
bookLimit：查用户是否试着借到超过指定借书量的书
userLevel：返回userStatus
checkUser:检查username和password是否对应
userBorrowBook: 借书 （但这是在user端，还需要在libraryBooks中定义一个borrowbook函数)

## normalUser:basicUser
normalUser继承了basicUser
**定义了:**
borrowMax = 3
*函数*
normalUser(username, password)的constructor
convertToHighLevel: 这个函数是用于把normal user换成high level user。本来想在form中实现的，但是最后没实现（过后有时间可以实现)
bookLimit: override函数，和normalUser的bookLimit一样

## highLevelUser:basicUser
highLevelUser继承了basicUser
和normalUser完全一样，但borrowMax = 5
convertToNormal 和convertToHighLevel相反
除了那些都一样。

## systemFailException
用于写systemFail的异常， 在Form2中使用与定义

## libraryBooks
用于记录书+各种关于书的函数
**定义了:**
totalNormal和totalProtected (用于记录总共有几样normal和protected的书，这个其实是用于过后要加书的部分，但是最后没实现)
定义了四个list
listOfNormalBooks, listOfProtectedBooks, numberOfNormalBooks, numberOfProtectedBooks
前面两个是用于记录所有normal books, protected books的名字
后两个是用于记录每本书有几个（也就是一本书可以有两个copies，所以用后两个记录每个书有几本）
*函数*
initializeBooks:用于把txt中记录书的内容都读出来，存到各个list里
findNormalBook和findProtectedBook: 返回在listOfNormalBooks和listOfProtectedBooks中的index
addBooks:加书（本来想在forms中加入这个功能，但是最后没加上)
bookAvailable:查一本书是否能借(图书管里还有没有这本书、书名对吗等)，用了findNormalBook和findProtectedBook
borrowBook:用于借书（这和basicUser的借书函数拥在一起)，这会在list里记录好借了书
returnBook:用于还书
saveBookNumbers:引用了updateNormalNumbers 和updateProtectedNumbers
updatedNormalNumbers和updateProtectedNumbers用于写入NormalBooks.txt和ProtectedBooks.txt

## librarySystem
**定义了:**
normalUserAccounts和highLevelUserAccounts两个list用于记录用户，分为normalUser和highLeveluser
也定义了libraryBooks allBooks
*函数*
librarySystem(libraryBooks books):constructor，需要一个libraryBooks类
loadedAccountUsername和loadedAccountPassword是返回username和password(本来用来debug)
usernameOverlap:查看有没有一个user已经有同样的useranme，如果有就返回false，用于create account，如果有同样username就不可以开账户
openAccount:开账号
closeAccount:关账号
findNormalAccount:找账户，返回normalUser，如果无，返回null
findHighLevelAccount:找账户，返回highLevelUser，如果无，返回null
initializeAccounts:从UserAccounts.txt读出账户信息，存入各种list
saveAccounts:把lists中的账户信息都存在UserAccounts.txt里
saveBorrowedBooks:用于存各个user已经借的书，存在BorrowedBooksHighLevel.txt和BorrowedBooksNormal.txt里
initializeBorrowedBooks:用于把BorrowedBooksHighLevel.txt和BorrowedBooksNormal.txt里的内容存到各种list里，初始化
