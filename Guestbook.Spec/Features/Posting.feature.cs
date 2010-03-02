// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.2.0.0
//      Runtime Version:4.0.30128.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Guestbook.Spec.Features
{
    using TechTalk.SpecFlow;
    
    
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Posting")]
    public partial class PostingFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Posting.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Posting", "In order to express my views\r\nAs a user\r\nI want to be able to post entries into t" +
                    "he guestbook", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigation to posting page")]
        public virtual void NavigationToPostingPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigation to posting page", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am on the guestbook page");
#line 8
 testRunner.Then("I should see a button labelled \"Post a New Entry\"");
#line 9
 testRunner.When("I click the button labelled \"Post a New Entry\"");
#line 10
 testRunner.Then("I am on the posting page");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Viewing the posting page")]
        public virtual void ViewingThePostingPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Viewing the posting page", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
    testRunner.Given("I am on the posting page");
#line 14
 testRunner.Then("I should see a field labelled \"Your name\"");
#line 15
  testRunner.And("I should see a field labelled \"Your comment\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Posting a valid entry")]
        public virtual void PostingAValidEntry()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Posting a valid entry", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("I am on the posting page");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Label",
                        "Value"});
            table1.AddRow(new string[] {
                        "Your name",
                        "Jakob"});
            table1.AddRow(new string[] {
                        "Your comment",
                        "Das ist gut!"});
#line 19
   testRunner.And("I have filled out the form as follows", ((string)(null)), table1);
#line 23
    testRunner.When("I click the button labelled \"Post\"");
#line 24
 testRunner.Then("I should be on the guestbook page");
#line 25
  testRunner.And("I see the flash message \"Thanks for posting!\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Comment",
                        "Posted date"});
            table2.AddRow(new string[] {
                        "Jakob",
                        "Das ist gut!",
                        "(within last minute)"});
#line 26
  testRunner.And("the guestbook entries includes the following", ((string)(null)), table2);
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}