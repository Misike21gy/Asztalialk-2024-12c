using program0402;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Tanulo diak2= new Tanulo();
            Assert.Equal(2010, diak2.szulev);
        }
    }
}