using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            Water w = new Water();
            Assert.Equal(0.10, w.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldHaveIceByDefault()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldNotHaveLemonByDefault()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal(Size.Medium, w.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal(0.10, w.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal(Size.Large, w.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal(0.10, w.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water w = new Water();
            Assert.Contains("Water", w.Ingredients);
        }
    }
}
