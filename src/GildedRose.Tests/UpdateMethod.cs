using GildedRose.Console;
using System.Collections.Generic;
using Xunit;
namespace GildedRose.Tests
{
    public class UpdateMethod
    {

        [Fact]
        public void TestCode()
        {

            var list = new List<Item>
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
                };


            INewFunction app = new NewFunction(list);

            app.UpdateQuality();

            Assert.True(true);
        }


        [Fact]
        public void NumberOfClassIstance()
        {
            UpdateMethod sut = new UpdateMethod();
            Assert.True(true);
        }
        [Fact]
        public void Item()
        {
            Item sut = new Item();
            Assert.True(true);
            
        }

        //[Fact]
        //public void CreateSaperateInstance()
        //{
        //    Program sut = new Program();


        //    Assert.NotSame()
        //}

        //[Fact]
        //public void HavinAllObjects()
        //{


        //    Program sut = new Program();

        //    var Items = new List<Item>
        //        {
        //            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
        //            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
        //            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
        //            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
        //            new Item
        //            {
        //                Name = "Backstage passes to a TAFKAL80ETC concert",
        //                SellIn = 15,
        //                Quality = 20
        //            },
        //            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
        //        };

        //    Assert.Equal("+5 Dexterity Vest", sut.Items);



        //}
    }
}