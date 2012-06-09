
using System.ComponentModel;
using Xunit;
namespace VibrantUtils.Portable.Facts
{
    public class NotifyPropertyChangedBaseFacts
    {
        [Fact]
        public void SettingTestProperty_FiresCorrectEvent()
        {
            // Arrange
            var obj = new TestObject();
            string propertyName = null;
            obj.PropertyChanged += (sender, args) => propertyName = args.PropertyName;

            // Act
            obj.TestProperty = "Flarg";

            // Assert
            Assert.Equal("TestProperty", propertyName);
        }

        [Fact]
        public void SettingTestProperty_DoesNotFireIfNewValueEqualsOldValue()
        {
            // Arrange
            var obj = new TestObject();
            int fireCount = 0;
            obj.PropertyChanged += (sender, args) => fireCount++;

            // Act
            obj.TestProperty = "Flarg";
            obj.TestProperty = "Flarg";
            obj.TestProperty = "Flarg";
            obj.TestProperty = "Flarg";

            // Assert
            Assert.Equal(1, fireCount);
        }

        public class TestObject : NotifyPropertyChangedBase
        {
            private string _prop;

            public string TestProperty
            {
                get { return _prop; }
                set { SetProperty(ref _prop, value); }
            }
        }
    }
}
