using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            while(true)
            { 

                char[] myArray = { '零', '壹', '贰', '叁', '肆', '伍', '陆', '柒', '捌', '玖' };
                char [] myUnit={'万','仟','佰','拾','元'};
                char[] myUnit1 = {'角','分'};
                char[] mychar=new char[10];
                char[] mycharx = new char[10];
                string strmoney,zheng,xiao="";
                string[] strzx = new string[2];
           
                Console.WriteLine("请输入money：");
                strmoney= Console.ReadLine();
                
                if (strmoney.IndexOf('.') != -1)
                {
                    strzx = strmoney.Split('.');
                    zheng = strzx[0];
                    xiao = strzx[1];
                }
                else
                {
                    zheng = strmoney;
                } 
                
         
                
                int len = zheng.Length;
                char[] pinjie= { };//必须给予初值，不然报错。
                if (len <= 5)
                {
                    pinjie = new char[2 * len];

                }
                else if (len > 5 && len < 9)
                {
                    pinjie = new char[3 * len+10];
                }
                else if (len==9)
                {
                    pinjie = new char[20];
                }


                
                int lenx = 0;
                if (strmoney.IndexOf('.') != -1)
                {
                    lenx = xiao.Length;
                  
                }
                char[] pinjiex = new char[2 * lenx];
                Console.WriteLine("你输入的money是：{0}", strmoney);
            
            
                for (int i = 0; i < zheng.Length; i++)
                  {
                    
                    switch (zheng[i])
                    {
                        case '1': mychar[i] = myArray[1]; break;
                        case '2': mychar[i] = myArray[2]; break;
                        case '3': mychar[i] = myArray[3]; break;
                        case '4': mychar[i] = myArray[4]; break;
                        case '5': mychar[i] = myArray[5]; break;
                        case '6': mychar[i] = myArray[6]; break;
                        case '7': mychar[i] = myArray[7]; break;
                        case '8': mychar[i] = myArray[8]; break;
                        case '9': mychar[i] = myArray[9]; break;
                        case '0': mychar[i] = myArray[0]; break;


                    }
                   
                  }

                for (int i = 0; i < xiao.Length; i++)
                {

                    switch (xiao[i])
                    {
                        case '1': mycharx[i] = myArray[1]; break;
                        case '2': mycharx[i] = myArray[2]; break;
                        case '3': mycharx[i] = myArray[3]; break;
                        case '4': mycharx[i] = myArray[4]; break;
                        case '5': mycharx[i] = myArray[5]; break;
                        case '6': mycharx[i] = myArray[6]; break;
                        case '7': mycharx[i] = myArray[7]; break;
                        case '8': mycharx[i] = myArray[8]; break;
                        case '9': mycharx[i] = myArray[9]; break;
                        case '0': mycharx[i] = myArray[0]; break;


                    }

                }


                if (len == 5)
                {

                    for (int j = 0, i = 0; i < len; i++)
                    {
                        if (mychar[i] != '零')
                        {
                            pinjie[j++] = mychar[i];
                            pinjie[j++] = myUnit[i];
                        }
                        else
                        {

                            if (mychar[i] == '零' && mychar[i - 1] == '零' && i != len - 1)
                            {
                                continue;
                            }

                            if (mychar[i] == '零' && i == len - 1 && pinjie[j - 1] != '零')
                            {
                                pinjie[j++] = myUnit[i]; break;
                            }
                            if (i == len - 1 && pinjie[j - 1] == '零')
                            {

                                pinjie[j - 1] = myUnit[i];

                            }
                            else
                            {
                                pinjie[j++] = mychar[i];
                            }






                        }


                    }
                }
                else if (len == 4)
                {

                    for (int j = 0, i = 0; i < len; i++)
                    {
                        if (mychar[i] != '零')
                        {
                            pinjie[j++] = mychar[i];
                            pinjie[j++] = myUnit[i + 1];
                        }
                        else
                        {

                            if (mychar[i] == '零' && mychar[i - 1] == '零' && i != 3)
                            {
                                continue;
                            }

                            if (mychar[i] == '零' && i == 3 && pinjie[j - 1] != '零')
                            {
                                pinjie[j++] = myUnit[i + 1]; break;
                            }
                            if (i == 3 && pinjie[j - 1] == '零')
                            {

                                pinjie[j - 1] = myUnit[i + 1];

                            }
                            else
                            {
                                pinjie[j++] = mychar[i];
                            }






                        }


                    }
                }
                else if (len == 3)
                {

                    for (int j = 0, i = 0; i < len; i++)
                    {
                        if (mychar[i] != '零')
                        {
                            pinjie[j++] = mychar[i];
                            pinjie[j++] = myUnit[i + 1 + 1];
                        }
                        else
                        {
                            if (mychar[i] == '零' && mychar[i - 1] == '零' && i != 2)
                            {
                                continue;
                            }
                            if (mychar[i] == '零' && i == 2 && pinjie[j - 1] != '零')
                            {
                                pinjie[j++] = myUnit[i + 1 + 1];
                                break;
                            }
                            if (i == 2 && pinjie[j - 1] == '零')
                            {
                                pinjie[j - 1] = myUnit[i + 1 + 1];

                            }
                            else
                            {
                                pinjie[j++] = mychar[i];
                            }



                        }


                    }
                }
                else if (len == 2)
                {

                    for (int j = 0, i = 0; i < len; i++)
                    {

                        if (mychar[len - 1] != '零')
                        {
                            pinjie[j++] = mychar[i];
                            pinjie[j++] = myUnit[i + 3];
                        }
                        else
                        {
                            pinjie[j++] = mychar[i];
                            pinjie[j++] = myUnit[i + 3];
                            pinjie[j++] = myUnit[i + 4];
                            break;
                        }


                    }

                }
                else if (len == 1)
                {

                    pinjie[0] = mychar[0];
                    pinjie[1] = myUnit[myUnit.Length - len];

                }
                else if (len == 6)
                {
                    for (int i = 0, j = 0; i < len; i++)
                    {
                        if (i == 0)
                        {
                            pinjie[j++] = mychar[0];
                            pinjie[j++] = myUnit[3];

                        }
                        else
                        {
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = mychar[i];
                                pinjie[j++] = myUnit[i - 1];
                            }
                            else
                            {
                                if (i == 1 && mychar[i] == '零')
                                {
                                    pinjie[j++] = myUnit[0];
                                }
                                if (mychar[i] == '零' && mychar[i - 1] == '零' && i != len - 1)
                                {
                                    continue;
                                }

                                if (i == len - 1 && pinjie[j - 1] != '零')
                                {
                                    pinjie[j++] = myUnit[i - 1]; break;
                                }
                                if (i == len - 1 && pinjie[j - 1] == '零')
                                {

                                    if (pinjie[j - 1] == '零')
                                    {
                                        pinjie[j - 1] = myUnit[i - 1];
                                    }
                                    else
                                    {
                                        pinjie[j] = myUnit[i - 1];
                                    }

                                }
                                else
                                {

                                    pinjie[j++] = mychar[i];

                                }
                            }




                        }
                    }









                }
                else if (len == 7)
                {
                    for (int i = 0, j = 0; i < len; i++)
                    {
                        if (i == 0)//处理百万位
                        {
                            pinjie[j++] = mychar[0];
                            pinjie[j++] = myUnit[2];

                        }
                        else if (i == 1)//十万
                        {
                            pinjie[j++] = mychar[1];
                            if (mychar[i] == '零')
                            {
                                continue;
                            }
                            else
                            {
                                pinjie[j++] = myUnit[3];
                            }

                        }

                        else if (i == 2)//万
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[0];
                            }
                            else
                            {
                                if (mychar[i - 1] == '零')
                                {
                                    j -= 2;
                                    pinjie[j++] = myUnit[0];
                                    pinjie[j] = '\0';

                                }
                                else
                                {
                                    j--;
                                    pinjie[j++] = myUnit[0];
                                }

                            }
                        }
                        else if (i == 3)//千
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[i - 2];
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (i == 4)//百
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {

                                pinjie[j++] = myUnit[i - 2];
                            }
                            else
                            {
                                if (mychar[i - 1] == '零')
                                {
                                    j--;
                                    continue;
                                }
                                else
                                {

                                    continue;
                                }
                            }
                        }
                        else if (i == 5)//十
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[i - 2];
                            }
                            else
                            {

                                if (mychar[i - 1] == '零')
                                {

                                    j--;
                                    continue;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else if (i == 6)//
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[i - 2];
                            }
                            else
                            {
                                /*if (mychar[i - 1] == '零')
                                {

                                    pinjie[j - 2] = myUnit[4];
                                }*/
                                if (mychar[i] == '零')
                                {


                                    if (mychar[i - 1] == '零')
                                    {
                                        pinjie[j - 2] = myUnit[4];
                                        pinjie[--j] = '\0';
                                    }
                                    else
                                    {
                                        pinjie[j - 1] = myUnit[4];

                                    }
                                }
                                else
                                {
                                    pinjie[j - 1] = myUnit[4];
                                }

                            }
                        }


                    }

                }
                else if (len == 8)
                {
                    for (int i = 0, j = 0; i < len; i++)
                    {
                        if (i == 0)
                        {
                            pinjie[j++] = mychar[0];
                            pinjie[j++] = myUnit[1];

                        }
                        else if (i == 1)//处理百万位
                        {
                            pinjie[j++] = mychar[1];
                            if (mychar[i] == '零')
                            {

                                continue;



                            }
                            else
                            {
                                pinjie[j++] = myUnit[2];
                            }


                        }
                        else if (i == 2)//十万
                        {
                            pinjie[j++] = mychar[2];
                            if (mychar[i] == '零')
                            {
                                if (mychar[i - 1] != '零')
                                {
                                    continue;
                                }
                                else
                                {
                                    j--;
                                    continue;
                                }



                            }
                            else
                            {
                                pinjie[j++] = myUnit[3];
                            }

                        }

                        else if (i == 3)//万
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[0];
                            }
                            else
                            {
                                if (mychar[i - 1] == '零')
                                {

                                    j -= 2;
                                    pinjie[j++] = myUnit[0];
                                    pinjie[j] = '\0';
                                    /*    else{ 
                                            j--;
                                            pinjie[j++] = myUnit[0];
                                            pinjie[j] = '\0';
                                        }*/

                                }
                                else
                                {
                                    j--;
                                    pinjie[j++] = myUnit[0];
                                }

                            }
                        }
                        else if (i == 4)//千
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[1];
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (i == 5)//百
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {

                                pinjie[j++] = myUnit[2];
                            }
                            else
                            {
                                if (mychar[i - 1] == '零')
                                {
                                    j--;
                                    continue;
                                }
                                else
                                {

                                    continue;
                                }
                            }
                        }
                        else if (i == 6)//十
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[3];
                            }
                            else
                            {

                                if (mychar[i - 1] == '零')
                                {

                                    j--;
                                    continue;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else if (i == 7)//
                        {
                            pinjie[j++] = mychar[i];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[4];
                            }
                            else
                            {
                                /*if (mychar[i - 1] == '零')
                                {

                                    pinjie[j - 2] = myUnit[4];
                                }*/
                                if (mychar[i] == '零')
                                {
                                    if (mychar[i - 1] == '零')
                                    {
                                        pinjie[j - 2] = myUnit[4];
                                        pinjie[--j] = '\0';
                                    }
                                    else
                                    {
                                        pinjie[j - 1] = myUnit[4];

                                    }
                                }

                                else
                                {
                                    pinjie[j - 1] = myUnit[4];
                                }

                            }
                        }


                    }
                }
                else if (len == 9) {
                    int j = 0;
                    pinjie[j++] = mychar[0];
                    pinjie[j++] = '亿';
                    for (int i = 1; i < len; i++)
                    {
                        if (i == 1)
                        {
                            pinjie[j++] = mychar[1];
                            pinjie[j++] = myUnit[1];

                        }
                        else if (i == 2)//处理百万位
                        {
                            pinjie[j++] = mychar[2];
                            if (mychar[i] == '零')
                            {

                                continue;



                            }
                            else
                            {
                                pinjie[j++] = myUnit[2];
                            }


                        }
                        else if (i == 3)//十万
                        {
                            pinjie[j++] = mychar[3];
                            if (mychar[i] == '零')
                            {
                                if (mychar[i - 1] != '零')
                                {
                                    continue;
                                }
                                else
                                {
                                    j--;
                                    continue;
                                }



                            }
                            else
                            {
                                pinjie[j++] = myUnit[3];
                            }

                        }

                        else if (i == 4)//万
                        {
                            pinjie[j++] = mychar[4];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[0];
                            }
                            else
                            {
                                if (mychar[i - 1] == '零')
                                {

                                    j -= 2;
                                    pinjie[j++] = myUnit[0];
                                    pinjie[j] = '\0';
                                    /*    else{ 
                                            j--;
                                            pinjie[j++] = myUnit[0];
                                            pinjie[j] = '\0';
                                        }*/

                                }
                                else
                                {
                                    j--;
                                    pinjie[j++] = myUnit[0];
                                }

                            }
                        }
                        else if (i == 5)//千
                        {
                            pinjie[j++] = mychar[5];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[1];
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (i == 6)//百
                        {
                            pinjie[j++] = mychar[6];
                            if (mychar[i] != '零')
                            {

                                pinjie[j++] = myUnit[2];
                            }
                            else
                            {
                                if (mychar[i - 1] == '零')
                                {
                                    j--;
                                    continue;
                                }
                                else
                                {

                                    continue;
                                }
                            }
                        }
                        else if (i == 7)//十
                        {
                            pinjie[j++] = mychar[7];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[3];
                            }
                            else
                            {

                                if (mychar[i - 1] == '零')
                                {

                                    j--;
                                    continue;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else if (i == 8)//
                        {
                            pinjie[j++] = mychar[8];
                            if (mychar[i] != '零')
                            {
                                pinjie[j++] = myUnit[4];
                            }
                            else
                            {
                                /*if (mychar[i - 1] == '零')
                                {

                                    pinjie[j - 2] = myUnit[4];
                                }*/
                                if (mychar[i] == '零')
                                {
                                    if (mychar[i - 1] == '零')
                                    {
                                        pinjie[j - 2] = myUnit[4];
                                        pinjie[--j] = '\0';
                                    }
                                    else
                                    {
                                        pinjie[j - 1] = myUnit[4];

                                    }
                                }

                                else
                                {
                                    pinjie[j - 1] = myUnit[4];
                                }

                            }
                        }


                    }
                }
                        /*foreach(var a in mychar)
                        {
                            Console.WriteLine(a);
                        }8*/
                        //小数部分处理
                        if (strmoney.IndexOf('.') != -1)
                {


                    if (xiao.Length==1)
                    {
                        for(int i = 0; i < xiao.Length; i++)
                        {
                            int j = 0;
                            pinjiex[j++] = mycharx[i];
                            pinjiex[j++] = myUnit1[i];
                        }
                        
                    }
                    if (xiao.Length == 2)
                    {
                        int j = 0;
                        for (int i = 0; i < xiao.Length; i++)
                        {
                            
                            if (mycharx[i] == '零')
                            {
                                continue;
                            }
                            pinjiex[j++] = mycharx[i];
                            pinjiex[j++] = myUnit1[i];
                        }

                    }

                }
                int i1 = 0;
                char[] pinjie1= { };
                if (len>=6) {
                while (pinjie[i1++] != '\0');
                pinjie1 =new char[i1-1];
                for (int i = 0; i < i1 - 1; i++)
                {
                     pinjie1[i] = pinjie[i];
                }



                }
                else
               {
                pinjie1 = new char[len*2];
                    for (int i = 0; i <len*2; i++)
                    {
                        pinjie1[i] = pinjie[i];
                    }

                }    
                                  
                
                string outmoney = new string(pinjie1);
                string outxiao = new string(pinjiex);
                outmoney += outxiao;
                Console.WriteLine("整数转换大写后为：{0}", outmoney);
               

                if (strmoney=="q")
                {
                    break;
                }
        }
    }
    }
}
