using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        // refactoring variable parameter

        public IList<Item> Items;

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            //NewFunction app = new NewFunction();

            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }

            };

            app.UpdateQuality();

            System.Console.ReadKey();

        }


        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var isAgedBrie = item.Name.Contains("Aged Brie");
                var isBackstagePass = item.Name.Contains("Backstage pass");
                var isSulfuras = item.Name.Contains("Sulfuras");
                var isConjured = item.Name.Contains("Conjuras");
                var isNormal = !isAgedBrie
                    && !isBackstagePass
                    && !isSulfuras
                    && !isConjured;

                //The legend itself!
                if (isSulfuras)
                    continue;

                else
                {
                    item.SellIn--;

                    if (isAgedBrie)
                    {
                        //Quality never exceeds 50
                        if (item.Quality == 50)
                            continue;

                        //Quality increases as time passes
                        else item.Quality++;
                    }
                    else if (isBackstagePass)
                    {
                        //Quality drops to zero after the concert
                        if (item.SellIn < 0)
                            item.Quality = 0;

                        else
                        {
                            //Quality never exceeds 50
                            if (item.Quality == 50)
                                continue;

                            //5 days or less to concert 
                            else if (item.SellIn <= 5)
                                item.Quality += 3;

                            //10 days or less to concert
                            else if (item.SellIn <= 10)
                                item.Quality += 2;

                            //Quality is never above 50
                            if (item.Quality > 50)
                                item.Quality = 50;
                        }
                    }
                    else //normal or conjured
                    {
                        //degrade twice as fast after deadline, by a unit before dead line
                        var degradeDegree = item.SellIn < 0 ? 2 : 1;

                        //degrade normally
                        item.Quality -= degradeDegree;

                        //conjured degrades twice as fast as normal items
                        if (isConjured)
                            item.Quality -= degradeDegree;

                        //Quality never drops below 0
                        if (item.Quality < 0)
                            item.Quality = 0;
                    }
                }
            }
        }
        


        // below is the previous code in comment

        //what needs to happen every day 
        //public void UpdateQualityOriginal()
        //{
        //    for (var i = 0; i < Items.Count; i++)
        //    {
        //        if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //        {
        //            if (Items[i].Quality > 0)
        //            {
        //                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                {
        //                    Items[i].Quality = Items[i].Quality - 1;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (Items[i].Quality < 50)
        //            {
        //                Items[i].Quality = Items[i].Quality + 1;

        //                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].SellIn < 11)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }

        //                    if (Items[i].SellIn < 6)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        // what need to happen to decrease the quality
        //        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //        {
        //            Items[i].SellIn = Items[i].SellIn - 1;
        //        }

        //        // what needs to happen if the sellin date is less thatn Zero
        //        if (Items[i].SellIn < 0)
        //        {
        //            if (Items[i].Name != "Aged Brie")
        //            {
        //                if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].Quality > 0)
        //                    {
        //                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                        {
        //                            Items[i].Quality = Items[i].Quality - 1;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Items[i].Quality = Items[i].Quality - Items[i].Quality;
        //                }
        //            }
        //            else
        //            {
        //                if (Items[i].Quality < 50)
        //                {
        //                    Items[i].Quality = Items[i].Quality + 1;
        //                }
        //            }
        //        }
        //    }
        //}



    }

}
