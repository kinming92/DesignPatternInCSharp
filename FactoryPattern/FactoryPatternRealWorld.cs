using System;
using System.Collections.Generic;

namespace FactoryPattern.RealWorld
{
    /// <summary>
    /// The 'Product' abstract class
    /// https://www.dofactory.com/net/factory-method-design-pattern
    /// </summary>

    abstract class Page { }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    /// 
    class SkillsPage : Page { }

    class EducationPage : Page { }

    class ExperiencePage : Page { }

    class IntroductionPage : Page { }

    class ResultsPage : Page { }

    class ConclusionPage : Page { }

    class SummaryPage : Page { }

    class BibliographyPage : Page { }



    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    /// 
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        // Constructor calls abstract Factory Method

        public Document()
        {
            CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        //Factory Method
        public abstract void CreatePages();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    /// 
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());

        }
    }

    // <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }



    /// <summary>
    /// MainApp startup class for Real-World 
    /// Factory Method Design Pattern.
    /// </summary>
    /// 

    public static class FactoryMethodRealWorld
    {
        public static void Program()
        {
            //note constructor call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine($"\n {document.GetType().Name} -- ");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine($" {page.GetType().Name}");
                }
            }
        }
    }



}