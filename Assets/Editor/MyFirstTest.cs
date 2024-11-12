using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class MyFirstTest{
    private AltDriver altDriver;

    [OneTimeSetUp] public void SetUp(){
        altDriver = new AltDriver();
    }

    [OneTimeTearDown] public void TearDown(){
        altDriver.Stop();
    }

    [Test] public void TestStartButton(){
        altDriver.LoadScene("Scene1");
        altDriver.FindObject(By.NAME, "StartButton").Tap();
        altDriver.WaitForCurrentSceneToBe("Scene2");
    }

    [Test] public void TestReturnButtonAfterStart(){
        altDriver.LoadScene("Scene1");
        altDriver.FindObject(By.NAME, "StartButton").Tap();
        altDriver.WaitForCurrentSceneToBe("Scene2");
        altDriver.FindObject(By.NAME, "ReturnButton").Tap();
        altDriver.WaitForCurrentSceneToBe("Scene1");
    }
}