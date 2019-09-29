using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal(SodasaurusFlavor.Cherry, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal(SodasaurusFlavor.Chocolate, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal(SodasaurusFlavor.Cola, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal(SodasaurusFlavor.Lime, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal(SodasaurusFlavor.Orange, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal(SodasaurusFlavor.RootBeer, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(1.50, soda.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveIceByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(Size.Small, soda.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(Size.Medium, soda.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(Size.Large, soda.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains("Water", soda.Ingredients);
            Assert.Contains("Natural Flavors", soda.Ingredients);
            Assert.Contains("Cane Sugar", soda.Ingredients);
        }
    }
}
