using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
    class String1
    {
        static void Main()
        {
            string str1 = "가나다라마바사";
            

            //Console.WriteLine(str1.Contains("가나"));
            //Console.WriteLine(str1.Contains('가'));
            //Console.WriteLine(str1.Contains("가"));  

            //Console.WriteLine(str1.IndexOf("마"));
            //Console.WriteLine(str1.IndexOf("바"));

            //오늘의 15번째 주문번호 인기많네 맛집이고,,
            string jumon = DateTime.Now.ToString("yyyyMMdd"); // ToString .. ㅈㄴ싫다 뭐가 이리 다양해 Tostring.. 형변환 되서 string으로 받네 10새..
            Console.WriteLine(jumon);

            int cnt = 15;
            //5자리로 채우는데 모자라면 0 을 붙이는거야 !! 왜쓰는걸까! 자매품 PadRight도 있음!
            string jumonNum = string.Concat(jumon, cnt.ToString().PadLeft(5, '0'));
            Console.WriteLine(jumonNum);

            while (true)
            {
                Console.Write("이메일 적어 : ");
                string str2 = Console.ReadLine();
                if (str2.IndexOf("@") < 0) // 같은걸로 if(!str2.Contains('@')) 츄르 폴스를 반환함 없으면 이건 !폴스 ...!
                    Console.WriteLine("유효한 이메일이 아니다 멍청아 다시 입력하도록");
                else
                {
                    Console.WriteLine("이거슨 유효한 이메일이다 잘했다");
                    break;
                }
            }

            //주민번호 7자리 받아서 생일 구하기 ..
            Console.Write("너의 주민 앞7자리를 적어라. : ");
            string yourJomin = Console.ReadLine();
            string sex;
            sex = (yourJomin.Substring(6) == "1") ? "남자" : "여자"; //7자리라는 가정하에..6자리부터 다 가져옴 ㅇㅋ?
            string year = string.Concat("19", yourJomin.Substring(0, 2)); //문자열 "합체"..먼가 있어보여..Concat..컨켓..컨고양이..오케
            
            Console.WriteLine($"넌 {year}년 {yourJomin.Substring(2,2)}월" +
                $" {yourJomin.Substring(4,2)}일 생일이고, {sex}다..!");

            //C:\Users\gudi\Pictures\Saved Pictures\cutecat.jpg
            string fileRoot = @"C:\Users\gudi\Pictures\Saved Pictures\cutecat.jpg"; //역슬래쉬 안받아줘 @ 붙여야 받아줘 아니면 \\ 해야 받아줌 까다로운쉑
            string cutecat = fileRoot.Substring((fileRoot.LastIndexOf("\\")+1));
            Console.WriteLine(cutecat);

            string ext = cutecat.Substring(cutecat.IndexOf('.') + 1);
            Console.WriteLine(ext.ToUpper());

            
        }
    }
}
