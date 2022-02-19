using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // for the savingPlansInterest
    // 因为enum不接受float，当要取出saving plan的利率，先取出int，再把int除于100
    public enum savingPlansInterest
    {
        // divide by 100
        lowCost = 101,
        midCost = 102,
        highCost = 103
    }
    // 要使用一个saving plan，获取利率就得先在账号存一定的钱
    public enum savingPlansMin
    {
        lowCost = 500,
        midCost = 1000,
        highCost = 2000
    }
}