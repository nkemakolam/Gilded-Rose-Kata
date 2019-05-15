using GildedRose.Console;
using Xunit;
namespace GildedRose.Tests
{
    public class UpdateMethod
    {
        [Fact]
        public void NumberOfClassIstance()
        {
            UpdateMethod sut  = new UpdateMethod();
            Assert.True(true);
        }
        //[Fact]
        //public void Item()
        //{
        //    Item sut = new Item();
        //    sut.Name = "+5 Dexterity Vest";
        //    Assert.Equal("+5 Dexterity Vest", Item);
        //}
    }
}