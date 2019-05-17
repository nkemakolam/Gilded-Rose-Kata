using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class NewFunction : INewFunction
    {
        public IList<Item> Items;

        public NewFunction(IList<Item> Items)
        {
            this.Items = Items;
        }

      


        public void UpdateQuality()
        {
            foreach (var item in this.Items)
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

    }
}
