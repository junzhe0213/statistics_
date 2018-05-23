using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistics
{
    class Program
    {
        static void Main(string[] args)
        {
             // 學生個人資料
            string[] names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] bloodTypes = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] genders = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] Zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };

            // 計算各個血型人數
            double count = 0,count2 = 0,count3 = 0,count4  = 0;
            for(int i = 0; i < bloodTypes.Length; i++)
            {
                if (bloodTypes[i] == "A")
                {
                    count++;
                }
                if (bloodTypes[i] == "B")
                {
                    count2++;
                }
                if (bloodTypes[i] == "O")
                {
                    count3++;
                }
                if (bloodTypes[i] == "AB")
                {
                    count4++;
                }

            }

            // 計算各個血型人數所占百分比
            double precentA = count / (double)bloodTypes.Length * 100;
            double precentB = count2 / (double)bloodTypes.Length * 100;
            double precentO = count3 / (double)bloodTypes.Length * 100;
            double precentAB = count4 / (double)bloodTypes.Length * 100;

            
            // 計算男生和女生分別的身高總和與人數總和
            int sum = 0;
            int sum2 = 0;
            int Count = 0;
            int Count2 = 0;

            for (int u = 0; u < heights.Length; u++)
            {
                if(heights[u]>100 && heights[u]<200)
                {
                    if(genders[u] == "女")
                    {
                        sum = sum + heights[u];
                        Count++;
                    }
                    if (genders[u] == "男")
                    {
                        sum2 = sum2 + heights[u];
                        Count2++;
                    }
                }
            }

            // 計算女生和男生的百分比
            double precentGirl = Count / (double)heights.Length * 100;
            double precentBoy = Count2 / (double)heights.Length * 100;

            // 計算女生和男生的身高平均與全部身高平均
            double avg = sum / Count;
            double avg2 = sum2 / Count2;
            double avgAll = (sum + sum2) / (Count + Count2);



            // 顯示女生和男生的人數與百分比
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 女生有 {0} 人 {1:0}%                                           ║", Count, precentGirl                      );
            Console.WriteLine("║ 男生有 {0} 人 {1:0}%                                           ║", Count2, precentBoy                      );
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

            // 顯示該血型總人數與百分比
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ A型的人有 {0} 人 {1:0}%                                        ║", count, precentA );
            Console.WriteLine("║ B型的人有 {0} 人 {1:0}%                                         ║", count2, precentB );
            Console.WriteLine("║ O型的人有 {0} 人 {1:0}%                                        ║", count3, precentO);
            Console.WriteLine("║ AB型的人有 {0} 人 {1:0}%                                         ║", count4, precentAB   );
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

            // 顯示女生和男生的身高平均與全部身高平均
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 女生身高平均:" + avg + "                                           ║");
            Console.WriteLine("║ 男生身高平均:" + avg2 + "                                           ║");
            Console.WriteLine("║ 全部身高平均:" + avgAll + "                                           ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");



            // 列出天蠍座O型的人
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 屬於天蠍座O型的人:                                         ║");
            for (int i = 0; i < Zodiac.Length; i++)
            {
                if (Zodiac[i] == "天蠍" && bloodTypes[i] == "O")
                {
                    Console.WriteLine("║ " + names[i]);
                }
            }
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");



            // 找出班上最高與最矮身高
            int max = -9999;
            int min = 9999;
            int n = 0;

            for (n = 0; n < heights.Length; n++)
            {
                if (heights[n] > 100 && heights[n] < 200)
                {
                    if (heights[n] > max)
                    {
                        max = heights[n];
                    }
                    if (heights[n] < min)
                    {
                        min = heights[n];
                    }
                }
            }

            // 顯示班上最高與最矮身高
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ 班上最高的身高:" + max + "                                         ║");
            Console.WriteLine("║ 班上最矮的身高:" + min + "                                         ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

            //螢幕暫停
            Console.ReadLine();

        }
    }
}
