using AspAndAngular.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspAndAngular.Infrastructure.EntityFrameworkCore
{
    public class ApplicationDbSeed
    {
        public static void Seed(ApplicationDbContext db)
        {
            if (db.Questions.Count() == 0)
            {
                var question1 = new Question
                {
                    ActualQuestion = "Which of the following choices isn't a cloud computing category?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ1 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Networking-as-a-Service (NaaS)"},
                        new Answer{ActualAnswer = "Platform-as-a-Service (PaaS)"},
                        new Answer{ActualAnswer = "Infrastructure-as-a-Service (IaaS)"},
                        new Answer{ActualAnswer = "Software-as-a-Service (SaaS)"}
                };
                db.Answers.AddRange(AnswersOfQ1);

                question1.Answers = AnswersOfQ1;
                question1.CorrectAnswer = AnswersOfQ1.FirstOrDefault(a => a.ActualAnswer == "Networking-as-a-Service (NaaS)");

                db.Add(question1);

                var question2 = new Question
                {
                    ActualQuestion = "Which of the following statements is true??",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ2 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "With Operating Expenses (OpEx), you are responsible for purchasing and maintaining your computing resources."},
                        new Answer{ActualAnswer = "With Operating Expenses (OpEx), you are only responsible for the computing resources that you use."},
                        new Answer{ActualAnswer = "With Capital Expenses (CapEx), you are only responsible for the computing resources that you use."},
                };
                db.Answers.AddRange(AnswersOfQ2);

                question2.Answers = AnswersOfQ2;
                question2.CorrectAnswer = AnswersOfQ2.FirstOrDefault(a => a.ActualAnswer == "With Operating Expenses (OpEx), you are only responsible for the computing resources that you use.");

                db.Add(question2);

                var question3 = new Question
                {
                    ActualQuestion = "Which of the following options isn't a type of cloud computing?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ3 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Distributed cloud"},
                        new Answer{ActualAnswer = "Hybrid cloud"},
                        new Answer{ActualAnswer = "Private cloud"},
                        new Answer{ActualAnswer = "Public cloud"}
                };
                db.Answers.AddRange(AnswersOfQ3);

                question3.Answers = AnswersOfQ3;
                question3.CorrectAnswer = AnswersOfQ3.FirstOrDefault(a => a.ActualAnswer == "Distributed cloud");

                db.Add(question3);


                var question4 = new Question
                {
                    ActualQuestion = "Which of the following choices isn't a benefit of using cloud services?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ4 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Scalability"},
                        new Answer{ActualAnswer = "Disaster recovery"},
                        new Answer{ActualAnswer = "High availability"},
                        new Answer{ActualAnswer = "Geographic isolation"}
                };
                db.Answers.AddRange(AnswersOfQ4);

                question4.Answers = AnswersOfQ4;
                question4.CorrectAnswer = AnswersOfQ4.FirstOrDefault(a => a.ActualAnswer == "Geographic isolation");

                db.Add(question4);

                var question5 = new Question
                {
                    ActualQuestion = "True or false: You need to purchase an Azure account before you can use any Azure resources.",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ5 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "False"},
                        new Answer{ActualAnswer = "True"},
                };
                db.Answers.AddRange(AnswersOfQ5);

                question5.Answers = AnswersOfQ5;
                question5.CorrectAnswer = AnswersOfQ5.FirstOrDefault(a => a.ActualAnswer == "False");

                db.Add(question5);

                var question6 = new Question
                {
                    ActualQuestion = "What is meant by cloud computing?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ6 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Delivery of computing services over the internet."},
                        new Answer{ActualAnswer = "Setting up your own datacenter."},
                        new Answer{ActualAnswer = "Using the internet."},
                };
                db.Answers.AddRange(AnswersOfQ6);

                question6.Answers = AnswersOfQ6;
                question6.CorrectAnswer = AnswersOfQ6.FirstOrDefault(a => a.ActualAnswer == "Delivery of computing services over the internet.");

                db.Add(question6);

                var question7 = new Question
                {
                    ActualQuestion = "What is not a reason to move to the cloud?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ7 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Faster innovation"},
                        new Answer{ActualAnswer = "A limited pool of services"},
                        new Answer{ActualAnswer = "Speech recognition and other cognitive services"},
                };
                db.Answers.AddRange(AnswersOfQ7);

                question7.Answers = AnswersOfQ7;
                question7.CorrectAnswer = AnswersOfQ7.FirstOrDefault(a => a.ActualAnswer == "A limited pool of services");

                db.Add(question7);

                var question8 = new Question
                {
                    ActualQuestion = "Which of the following can be used to manage governance across multiple Azure subscriptions?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ8 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure initiatives"},
                        new Answer{ActualAnswer = "Management groups"},
                        new Answer{ActualAnswer = "Resource groups"},
                };
                db.Answers.AddRange(AnswersOfQ8);

                question8.Answers = AnswersOfQ8;
                question8.CorrectAnswer = AnswersOfQ8.FirstOrDefault(a => a.ActualAnswer == "Management groups");

                db.Add(question8);

                var question9 = new Question
                {
                    ActualQuestion = "Which of the following is a logical unit of Azure services that links to an Azure account?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ9 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure subscription"},
                        new Answer{ActualAnswer = "Management group"},
                        new Answer{ActualAnswer = "Resource group"},
                        new Answer{ActualAnswer = "Public cloud"},
                };
                db.Answers.AddRange(AnswersOfQ9);

                question9.Answers = AnswersOfQ9;
                question9.CorrectAnswer = AnswersOfQ9.FirstOrDefault(a => a.ActualAnswer == "Azure subscription");

                db.Add(question9);

                var question10 = new Question
                {
                    ActualQuestion = "Which of the following features doesn't apply to resource groups?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ10 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Resources can be in only one resource group."},
                        new Answer{ActualAnswer = "Role-based access control can be applied to the resource group."},
                        new Answer{ActualAnswer = "Resource groups can be nested."},
                };
                db.Answers.AddRange(AnswersOfQ10);

                question10.Answers = AnswersOfQ10;
                question10.CorrectAnswer = AnswersOfQ10.FirstOrDefault(a => a.ActualAnswer == "Resource groups can be nested.");

                db.Add(question10);

                var question11 = new Question
                {
                    ActualQuestion = "Which of the following statements is a valid statement about an Azure subscription?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AnswersOfQ11 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Using Azure doesn't require a subscription."},
                        new Answer{ActualAnswer = "An Azure subscription is a logical unit of Azure services."},
                };
                db.Answers.AddRange(AnswersOfQ11);

                question11.Answers = AnswersOfQ11;
                question11.CorrectAnswer = AnswersOfQ11.FirstOrDefault(a => a.ActualAnswer == "An Azure subscription is a logical unit of Azure services.");

                db.Add(question11);

                var question12 = new Question
                {
                    ActualQuestion = "Which Azure compute resource can be deployed to manage a set of identical virtual machines?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ12 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Virtual machine scale sets"},
                        new Answer{ActualAnswer = "Virtual machine availability sets"},
                        new Answer{ActualAnswer = "Virtual machine availability zones"},
                };
                db.Answers.AddRange(AnswersOfQ12);

                question12.Answers = AnswersOfQ12;
                question12.CorrectAnswer = AnswersOfQ12.FirstOrDefault(a => a.ActualAnswer == "Virtual machine scale sets");

                db.Add(question12);

                var question13 = new Question
                {
                    ActualQuestion = "Which of the following services should be used when the primary concern is to perform work in response to an event (often via a REST command) that needs a response in a few seconds?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ13 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Functions"},
                        new Answer{ActualAnswer = "Azure App Service"},
                        new Answer{ActualAnswer = "Azure Container Instances"},
                };
                db.Answers.AddRange(AnswersOfQ13);

                question13.Answers = AnswersOfQ13;
                question13.CorrectAnswer = AnswersOfQ13.FirstOrDefault(a => a.ActualAnswer == "Azure Functions");

                db.Add(question13);

                var question14 = new Question
                {
                    ActualQuestion = "Your company has a team of remote workers that need to use Windows-based software to develop your company's applications, but your team members are using various operating systems like MacOS, Linux, and Windows. Which Azure compute service would help resolve this scenario?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ14 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure App Service"},
                        new Answer{ActualAnswer = "Windows Virtual Desktop"},
                        new Answer{ActualAnswer = "Azure Container Instances"},
                };
                db.Answers.AddRange(AnswersOfQ14);

                question14.Answers = AnswersOfQ14;
                question14.CorrectAnswer = AnswersOfQ14.FirstOrDefault(a => a.ActualAnswer == "Windows Virtual Desktop");

                db.Add(question14);

                var question15 = new Question
                {
                    ActualQuestion = "Tailwind Traders wants to create a secure communication tunnel between its branch offices. Which of the following technologies can't be used?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ15 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Point-to-site virtual private network"},
                        new Answer{ActualAnswer = "Implicit FTP over SSL"},
                        new Answer{ActualAnswer = "Azure ExpressRoute"},
                        new Answer{ActualAnswer = "Site-to-site virtual private network"},
                };
                db.Answers.AddRange(AnswersOfQ15);

                question15.Answers = AnswersOfQ15;
                question15.CorrectAnswer = AnswersOfQ15.FirstOrDefault(a => a.ActualAnswer == "Implicit FTP over SSL");

                db.Add(question15);

                var question16 = new Question
                {
                    ActualQuestion = "Tailwind Traders wants to use Azure ExpressRoute to connect its on-premises network to the Microsoft cloud. Which of the following choices isn't an ExpressRoute model that Tailwind Traders can use?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ16 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Any-to-any connection"},
                        new Answer{ActualAnswer = "Site-to-site virtual private network"},
                        new Answer{ActualAnswer = "Point-to-point Ethernet connection"},
                        new Answer{ActualAnswer = "CloudExchange colocation"},
                };
                db.Answers.AddRange(AnswersOfQ16);

                question16.Answers = AnswersOfQ16;
                question16.CorrectAnswer = AnswersOfQ16.FirstOrDefault(a => a.ActualAnswer == "Site-to-site virtual private network");

                db.Add(question16);

                var question17 = new Question
                {
                    ActualQuestion = "Which of the following options can you use to link virtual networks?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ17 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Network address translation"},
                        new Answer{ActualAnswer = "Multi-chassis link aggregation"},
                        new Answer{ActualAnswer = "Dynamic Host Configuration Protocol"},
                        new Answer{ActualAnswer = "Virtual network peering"},
                };
                db.Answers.AddRange(AnswersOfQ17);

                question17.Answers = AnswersOfQ17;
                question17.CorrectAnswer = AnswersOfQ17.FirstOrDefault(a => a.ActualAnswer == "Virtual network peering");

                db.Add(question17);

                var question18 = new Question
                {
                    ActualQuestion = "Which of the following options isn't a benefit of ExpressRoute?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ18 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Redundant connectivity"},
                        new Answer{ActualAnswer = "Consistent network throughput"},
                        new Answer{ActualAnswer = "Encrypted network communication"},
                        new Answer{ActualAnswer = "Access to Microsoft cloud services"},
                };
                db.Answers.AddRange(AnswersOfQ18);

                question18.Answers = AnswersOfQ18;
                question18.CorrectAnswer = AnswersOfQ18.FirstOrDefault(a => a.ActualAnswer == "Encrypted network communication");

                db.Add(question18);

                var question19 = new Question
                {
                    ActualQuestion = "What is the first step that you would take in order to share an image file as a blob in Azure Storage?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ19 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Create an Azure Storage container to store the image."},
                        new Answer{ActualAnswer = "Create an Azure Storage account."},
                        new Answer{ActualAnswer = "Upload the image file and create a container."},
                        new Answer{ActualAnswer = "Use a Shared Access Signature (SAS) token to restrict access to the image."},
                };
                db.Answers.AddRange(AnswersOfQ19);

                question19.Answers = AnswersOfQ19;
                question19.CorrectAnswer = AnswersOfQ19.FirstOrDefault(a => a.ActualAnswer == "Create an Azure Storage account.");

                db.Add(question19);

                var question20 = new Question
                {
                    ActualQuestion = "Which Azure Storage option is better for storing data for backup and restore, disaster recovery, and archiving?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ20 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Files Storage"},
                        new Answer{ActualAnswer = "Azure Disk Storage"},
                        new Answer{ActualAnswer = "Azure Blob Storage"},
                };
                db.Answers.AddRange(AnswersOfQ20);

                question20.Answers = AnswersOfQ20;
                question20.CorrectAnswer = AnswersOfQ20.FirstOrDefault(a => a.ActualAnswer == "Azure Blob Storage");

                db.Add(question20);

                var question21 = new Question
                {
                    ActualQuestion = "Your development team is interested in writing Graph-based applications that take advantage of the Gremlin API. Which option would be ideal for that scenario?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ21 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Cosmos DB"},
                        new Answer{ActualAnswer = "Azure SQL Database"},
                        new Answer{ActualAnswer = "Azure Databricks"},
                        new Answer{ActualAnswer = "Azure Database for PostgreSQL"},
                };
                db.Answers.AddRange(AnswersOfQ21);

                question21.Answers = AnswersOfQ21;
                question21.CorrectAnswer = AnswersOfQ21.FirstOrDefault(a => a.ActualAnswer == "Azure Cosmos DB");

                db.Add(question21);

                var question22 = new Question
                {
                    ActualQuestion = "Tailwind Traders uses the LAMP stack for several of its websites. Which option would be ideal for migration?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ22 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Cosmos DB"},
                        new Answer{ActualAnswer = "Azure Database for MySQL"},
                        new Answer{ActualAnswer = "Azure Database for PostgreSQL"},
                };
                db.Answers.AddRange(AnswersOfQ22);

                question22.Answers = AnswersOfQ22;
                question22.CorrectAnswer = AnswersOfQ22.FirstOrDefault(a => a.ActualAnswer == "Azure Database for MySQL");

                db.Add(question22);

                var question23 = new Question
                {
                    ActualQuestion = "Tailwind Traders has millions of log entries that it wants to analyze. Which option would be ideal for analysis?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AnswersOfQ23 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Cosmos DB"},
                        new Answer{ActualAnswer = "Azure SQL Database"},
                        new Answer{ActualAnswer = "Azure Database for PostgreSQL"},
                        new Answer{ActualAnswer = "Azure Synapse Analytics"},
                };
                db.Answers.AddRange(AnswersOfQ23);

                question23.Answers = AnswersOfQ23;
                question23.CorrectAnswer = AnswersOfQ23.FirstOrDefault(a => a.ActualAnswer == "Azure Synapse Analytics");

                db.Add(question23);

                var question24 = new Question
                {
                    ActualQuestion = "A company wants to build a new voting kiosk for sales to governments around the world. Which IoT technologies should the company choose to ensure the highest degree of security?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ24 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "IoT Hub"},
                        new Answer{ActualAnswer = "IoT Central"},
                        new Answer{ActualAnswer = "Azure Sphere"},
                };
                db.Answers.AddRange(AnswersOfQ24);

                question24.Answers = AnswersOfQ24;
                question24.CorrectAnswer = AnswersOfQ24.FirstOrDefault(a => a.ActualAnswer == "Azure Sphere");

                db.Add(question24);

                var question25 = new Question
                {
                    ActualQuestion = "A company wants to quickly manage its individual IoT devices by using a web-based user interface. Which IoT technology should it choose?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ25 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "IoT Hub"},
                        new Answer{ActualAnswer = "IoT Central"},
                        new Answer{ActualAnswer = "Azure Sphere"},
                };
                db.Answers.AddRange(AnswersOfQ25);

                question25.Answers = AnswersOfQ25;
                question25.CorrectAnswer = AnswersOfQ25.FirstOrDefault(a => a.ActualAnswer == "IoT Central");

                db.Add(question25);

                var question26 = new Question
                {
                    ActualQuestion = "You want to send messages from the IoT device to the cloud and vice versa. Which IoT technology can send and receive messages?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ26 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "IoT Hub"},
                        new Answer{ActualAnswer = "IoT Central"},
                        new Answer{ActualAnswer = "Azure Sphere"},
                };
                db.Answers.AddRange(AnswersOfQ26);

                question26.Answers = AnswersOfQ26;
                question26.CorrectAnswer = AnswersOfQ26.FirstOrDefault(a => a.ActualAnswer == "IoT Hub");

                db.Add(question26);

                var question27 = new Question
                {
                    ActualQuestion = "You need to predict future behavior based on previous actions. Which product option should you select as a candidate?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ27 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Machine Learning"},
                        new Answer{ActualAnswer = "Azure Bot Service"},
                        new Answer{ActualAnswer = "Azure Cognitive Services"},
                };
                db.Answers.AddRange(AnswersOfQ27);

                question27.Answers = AnswersOfQ27;
                question27.CorrectAnswer = AnswersOfQ27.FirstOrDefault(a => a.ActualAnswer == "Azure Machine Learning");

                db.Add(question27);

                var question28 = new Question
                {
                    ActualQuestion = "You need to create a human-computer interface that uses natural language to answer customer questions. Which product option should you select as a candidate?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ28 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Machine Learning"},
                        new Answer{ActualAnswer = "Azure Cognitive Services"},
                        new Answer{ActualAnswer = "Azure Bot Service"},
                };
                db.Answers.AddRange(AnswersOfQ28);

                question28.Answers = AnswersOfQ28;
                question28.CorrectAnswer = AnswersOfQ28.FirstOrDefault(a => a.ActualAnswer == "Azure Bot Service");

                db.Add(question28);

                var question29 = new Question
                {
                    ActualQuestion = "You need to identify the content of product images to automatically create alt tags for images formatted properly. Which product option is the best candidate?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ29 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Machine Learning"},
                        new Answer{ActualAnswer = "Azure Cognitive Services"},
                        new Answer{ActualAnswer = "Azure Bot Service"},
                };
                db.Answers.AddRange(AnswersOfQ29);

                question29.Answers = AnswersOfQ29;
                question29.CorrectAnswer = AnswersOfQ29.FirstOrDefault(a => a.ActualAnswer == "Azure Cognitive Services");

                db.Add(question29);

                var question30 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system from its datacenter to the cloud. The payment system consists of virtual machines (VMs) and SQL Server databases." +
                                     "\nHere are a few security requirements that the company identifies as it plans the migration:" + "\nIt wants to ensure a good security posture across all of its systems, both on Azure and on - premises." +
                                     "\nIn the datacenter, access to VMs requires a TLS certificate.The company needs a place to safely store and manage its certificates." + "\nHere are some additional requirements that relate to regulatory compliance:" +
                                     "\nTailwind Traders must store certain customer data on-premises, in its datacenter." +
                                     "\nFor certain workloads, the company must be the only customer running VMs on the physical hardware." +
                                     "\nThe company must only run approved business applications on each VM." + "\n On Azure, Tailwind Traders will use both standard VMs and VMs that run on dedicated physical hardware." +
                                     "\nIn the datacenter, the company will run VMs that can connect to databases within its internal network." +
                                     "\n\nHow can Tailwind Traders enforce having only certain applications run on its VMs?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };

                var AnswersOfQ30 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Connect your VMs to Azure Sentinel."},
                        new Answer{ActualAnswer = "Create an application control rule in Azure Security Center."},
                        new Answer{ActualAnswer = "Periodically run a script that lists the running processes on each VM. The IT manager can then shut down any applications that shouldn't be running."},
                };
                db.Answers.AddRange(AnswersOfQ30);

                question30.Answers = AnswersOfQ30;
                question30.CorrectAnswer = AnswersOfQ30.FirstOrDefault(a => a.ActualAnswer == "Create an application control rule in Azure Security Center.");

                db.Add(question30);

                var question31 = new Question
                {
                    ActualQuestion = "You need to process messages from a queue, parse them by using some existing imperative logic written in Java, and then send them to a third-party API. Which serverless option should you choose?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ31 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Functions"},
                        new Answer{ActualAnswer = "Azure Logic Apps"},
                };
                db.Answers.AddRange(AnswersOfQ31);

                question31.Answers = AnswersOfQ31;
                question31.CorrectAnswer = AnswersOfQ31.FirstOrDefault(a => a.ActualAnswer == "Azure Functions");

                db.Add(question31);

                var question32 = new Question
                {
                    ActualQuestion = "You want to orchestrate a workflow by using APIs from several well-known services. Which is the best option for this scenario?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ32 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Functions"},
                        new Answer{ActualAnswer = "Azure Logic Apps"},
                };
                db.Answers.AddRange(AnswersOfQ32);

                question32.Answers = AnswersOfQ32;
                question32.CorrectAnswer = AnswersOfQ32.FirstOrDefault(a => a.ActualAnswer == "Azure Logic Apps");

                db.Add(question32);

                var question33 = new Question
                {
                    ActualQuestion = "Your team has limited experience with writing custom code, but it sees tremendous value in automating several important business processes. Which of the following options is your team's best option?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ33 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Functions"},
                        new Answer{ActualAnswer = "Azure Logic Apps"},
                };
                db.Answers.AddRange(AnswersOfQ33);

                question33.Answers = AnswersOfQ33;
                question33.CorrectAnswer = AnswersOfQ33.FirstOrDefault(a => a.ActualAnswer == "Azure Logic Apps");

                db.Add(question33);

                var question34 = new Question
                {
                    ActualQuestion = "Which of the following choices would not be used to automate a CI/CD process?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ34 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Pipelines"},
                        new Answer{ActualAnswer = "GitHub Actions"},
                        new Answer{ActualAnswer = "Azure Boards"},
                };
                db.Answers.AddRange(AnswersOfQ34);

                question34.Answers = AnswersOfQ34;
                question34.CorrectAnswer = AnswersOfQ34.FirstOrDefault(a => a.ActualAnswer == "Azure Boards");

                db.Add(question34);

                var question35 = new Question
                {
                    ActualQuestion = "Which service could help you manage the VMs that your developers and testers need to ensure that your new app works across various operating systems?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ35 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure DevTest Labs"},
                        new Answer{ActualAnswer = "Azure Test Labs"},
                        new Answer{ActualAnswer = "Azure Repos"},
                };
                db.Answers.AddRange(AnswersOfQ35);

                question35.Answers = AnswersOfQ35;
                question35.CorrectAnswer = AnswersOfQ35.FirstOrDefault(a => a.ActualAnswer == "Azure DevTest Labs");

                db.Add(question35);

                var question36 = new Question
                {
                    ActualQuestion = "Which service lacks features to assign individual developers tasks to work on?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ36 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Boards"},
                        new Answer{ActualAnswer = "GitHub"},
                        new Answer{ActualAnswer = "Azure Pipelines"},
                };
                db.Answers.AddRange(AnswersOfQ36);

                question36.Answers = AnswersOfQ36;
                question36.CorrectAnswer = AnswersOfQ36.FirstOrDefault(a => a.ActualAnswer == "Azure Pipelines");

                db.Add(question36);

                var question37 = new Question
                {
                    ActualQuestion = "As an administrator, you need to retrieve the IP address from a particular VM by using Bash. Which of the following tools should you use?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ37 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "ARM templates"},
                        new Answer{ActualAnswer = "Azure PowerShell"},
                        new Answer{ActualAnswer = "The Azure portal"},
                        new Answer{ActualAnswer = "The Azure CLI"},
                };
                db.Answers.AddRange(AnswersOfQ37);

                question37.Answers = AnswersOfQ37;
                question37.CorrectAnswer = AnswersOfQ37.FirstOrDefault(a => a.ActualAnswer == "The Azure CLI");

                db.Add(question37);

                var question38 = new Question
                {
                    ActualQuestion = "You're a developer who needs to set up your first VM to host a process that runs nightly. Which of the following tools is your best choice?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ38 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "ARM templates"},
                        new Answer{ActualAnswer = "Azure PowerShell"},
                        new Answer{ActualAnswer = "The Azure portal"},
                        new Answer{ActualAnswer = "The Azure CLI"},
                };
                db.Answers.AddRange(AnswersOfQ38);

                question38.Answers = AnswersOfQ38;
                question38.CorrectAnswer = AnswersOfQ38.FirstOrDefault(a => a.ActualAnswer == "The Azure portal");

                db.Add(question38);

                var question39 = new Question
                {
                    ActualQuestion = "What is the best infrastructure-as-code option for quickly and reliably setting up your entire cloud infrastructure declaratively?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ39 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "ARM templates"},
                        new Answer{ActualAnswer = "Azure PowerShell"},
                        new Answer{ActualAnswer = "The Azure portal"},
                        new Answer{ActualAnswer = "The Azure CLI"},
                };
                db.Answers.AddRange(AnswersOfQ39);

                question39.Answers = AnswersOfQ39;
                question39.CorrectAnswer = AnswersOfQ39.FirstOrDefault(a => a.ActualAnswer == "ARM templates");

                db.Add(question39);

                var question40 = new Question
                {
                    ActualQuestion = "You want to be alerted when new recommendations to improve your cloud environment are available. Which service will do this?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ40 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Advisor"},
                        new Answer{ActualAnswer = "Azure Monitor"},
                        new Answer{ActualAnswer = "Azure Service Health"},
                };
                db.Answers.AddRange(AnswersOfQ40);

                question40.Answers = AnswersOfQ40;
                question40.CorrectAnswer = AnswersOfQ40.FirstOrDefault(a => a.ActualAnswer == "Azure Advisor");

                db.Add(question40);

                var question41 = new Question
                {
                    ActualQuestion = "Which service provides official outage root cause analyses (RCAs) for Azure incidents?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ41 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Advisor"},
                        new Answer{ActualAnswer = "Azure Monitor"},
                        new Answer{ActualAnswer = "Azure Service Health"},
                };
                db.Answers.AddRange(AnswersOfQ41);

                question41.Answers = AnswersOfQ41;
                question41.CorrectAnswer = AnswersOfQ41.FirstOrDefault(a => a.ActualAnswer == "Azure Service Health");

                db.Add(question41);

                var question42 = new Question
                {
                    ActualQuestion = "Which service is a platform that powers Application Insights, monitoring for VMs, containers, and Kubernetes?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AnswersOfQ42 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Advisor"},
                        new Answer{ActualAnswer = "Azure Monitor"},
                        new Answer{ActualAnswer = "Azure Service Health"},
                };
                db.Answers.AddRange(AnswersOfQ42);

                question42.Answers = AnswersOfQ42;
                question42.CorrectAnswer = AnswersOfQ42.FirstOrDefault(a => a.ActualAnswer == "Azure Monitor");

                db.Add(question42);

                var question43 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system from its datacenter to the cloud. The payment system consists of virtual machines (VMs) and SQL Server databases." +
                                     "\nHere are a few security requirements that the company identifies as it plans the migration:" + "\nIt wants to ensure a good security posture across all of its systems, both on Azure and on - premises." +
                                     "\nIn the datacenter, access to VMs requires a TLS certificate.The company needs a place to safely store and manage its certificates." + "\nHere are some additional requirements that relate to regulatory compliance:" +
                                     "\nTailwind Traders must store certain customer data on-premises, in its datacenter." +
                                     "\nFor certain workloads, the company must be the only customer running VMs on the physical hardware." +
                                     "\nThe company must only run approved business applications on each VM." + "\n On Azure, Tailwind Traders will use both standard VMs and VMs that run on dedicated physical hardware." +
                                     "\nIn the datacenter, the company will run VMs that can connect to databases within its internal network." +
                                     "\n\nWhat's the easiest way for Tailwind Traders to combine security data from all of its monitoring tools into a single report that it can take action on?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };

                var AnswersOfQ43 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Collect security data in Azure Sentinel."},
                        new Answer{ActualAnswer = "Build a custom tool that collects security data, and displays a report through a web application."},
                        new Answer{ActualAnswer = "Look through each security log daily and email a summary to your team."},
                };
                db.Answers.AddRange(AnswersOfQ43);

                question43.Answers = AnswersOfQ43;
                question43.CorrectAnswer = AnswersOfQ43.FirstOrDefault(a => a.ActualAnswer == "Collect security data in Azure Sentinel.");

                db.Add(question43);

                var question44 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system from its datacenter to the cloud. The payment system consists of virtual machines (VMs) and SQL Server databases." +
                                     "\nHere are a few security requirements that the company identifies as it plans the migration:" + "\nIt wants to ensure a good security posture across all of its systems, both on Azure and on - premises." +
                                     "\nIn the datacenter, access to VMs requires a TLS certificate.The company needs a place to safely store and manage its certificates." + "\nHere are some additional requirements that relate to regulatory compliance:" +
                                     "\nTailwind Traders must store certain customer data on-premises, in its datacenter." +
                                     "\nFor certain workloads, the company must be the only customer running VMs on the physical hardware." +
                                     "\nThe company must only run approved business applications on each VM." + "\n On Azure, Tailwind Traders will use both standard VMs and VMs that run on dedicated physical hardware." +
                                     "\nIn the datacenter, the company will run VMs that can connect to databases within its internal network." +
                                     "\n\nWhich is the best way for Tailwind Traders to safely store its certificates so that they're accessible to cloud VMs?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };

                var AnswersOfQ44 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Place the certificates on a network share."},
                        new Answer{ActualAnswer = "Store them on a VM that's protected by a password."},
                        new Answer{ActualAnswer = "Store the certificates in Azure Key Vault."},
                };
                db.Answers.AddRange(AnswersOfQ44);

                question44.Answers = AnswersOfQ44;
                question44.CorrectAnswer = AnswersOfQ44.FirstOrDefault(a => a.ActualAnswer == "Store the certificates in Azure Key Vault.");

                db.Add(question44);

                var question45 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system from its datacenter to the cloud. The payment system consists of virtual machines (VMs) and SQL Server databases." +
                                     "\nHere are a few security requirements that the company identifies as it plans the migration:" + "\nIt wants to ensure a good security posture across all of its systems, both on Azure and on - premises." +
                                     "\nIn the datacenter, access to VMs requires a TLS certificate.The company needs a place to safely store and manage its certificates." + "\nHere are some additional requirements that relate to regulatory compliance:" +
                                     "\nTailwind Traders must store certain customer data on-premises, in its datacenter." +
                                     "\nFor certain workloads, the company must be the only customer running VMs on the physical hardware." +
                                     "\nThe company must only run approved business applications on each VM." + "\n On Azure, Tailwind Traders will use both standard VMs and VMs that run on dedicated physical hardware." +
                                     "\nIn the datacenter, the company will run VMs that can connect to databases within its internal network." +
                                     "\n\nHow can Tailwind Traders ensure that certain VM workloads are physically isolated from workloads being run by other Azure customers?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };

                var AnswersOfQ45 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Configure the network to ensure that VMs on the same physical host are isolated."},
                        new Answer{ActualAnswer = "This is not possible. These workloads need to be run on-premises."},
                        new Answer{ActualAnswer = "Run the VMs on Azure Dedicated Host."},
                };
                db.Answers.AddRange(AnswersOfQ45);

                question45.Answers = AnswersOfQ45;
                question45.CorrectAnswer = AnswersOfQ45.FirstOrDefault(a => a.ActualAnswer == "This is not possible. These workloads need to be run on-premises.");

                db.Add(question45);

                var question46 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system to Azure. The processing of online orders begins through a website," +
                                     "\nwhich Tailwind Traders manages through Azure App Service. (App Service is a way to host web applications on Azure.)" +
                                     "\nThe web application that runs the website passes order information to virtual machines(VMs)," +
                                     "\nwhich further process each order.These VMs exist on an Azure virtual network," +
                                     "\nbut they need to access the internet to retrieve software packages and system updates." +
                                     "\nThe security team wants to ensure that only valid network traffic reaches the company's Azure resources." +
                                     "\nAs an extra layer of defense, the team also wants to ensure that the VMs can reach only trusted hosts on specific ports." +
                                     "\n\nAn attacker can bring down your website by sending a large volume of network traffic to your servers." +
                                     "\nWhich Azure service can help Tailwind Traders protect its App Service instance from this kind of attack?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };
                var AnswersOfQ46 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Azure Firewall"},
                        new Answer{ActualAnswer = "Network security groups"},
                        new Answer{ActualAnswer = "Azure DDoS Protection"},
                };
                db.Answers.AddRange(AnswersOfQ46);

                question46.Answers = AnswersOfQ46;
                question46.CorrectAnswer = AnswersOfQ46.FirstOrDefault(a => a.ActualAnswer == "Azure DDoS Protection");

                db.Add(question46);

                var question47 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system to Azure. The processing of online orders begins through a website," +
                                     "\nwhich Tailwind Traders manages through Azure App Service. (App Service is a way to host web applications on Azure.)" +
                                     "\nThe web application that runs the website passes order information to virtual machines(VMs)," +
                                     "\nwhich further process each order.These VMs exist on an Azure virtual network," +
                                     "\nbut they need to access the internet to retrieve software packages and system updates." +
                                     "\nThe security team wants to ensure that only valid network traffic reaches the company's Azure resources." +
                                     "\nAs an extra layer of defense, the team also wants to ensure that the VMs can reach only trusted hosts on specific ports." +
                                     "\n\nWhat's the best way for Tailwind Traders to limit all outbound traffic from VMs to known hosts?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };
                var AnswersOfQ47 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Configure Azure DDoS Protection to limit network access to trusted ports and hosts."},
                        new Answer{ActualAnswer = "Create application rules in Azure Firewall."},
                        new Answer{ActualAnswer = "Ensure that all running applications communicate with only trusted ports and hosts."},
                };
                db.Answers.AddRange(AnswersOfQ47);

                question47.Answers = AnswersOfQ47;
                question47.CorrectAnswer = AnswersOfQ47.FirstOrDefault(a => a.ActualAnswer == "Create application rules in Azure Firewall.");

                db.Add(question47);

                var question48 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system to Azure. The processing of online orders begins through a website," +
                                     "\nwhich Tailwind Traders manages through Azure App Service. (App Service is a way to host web applications on Azure.)" +
                                     "\nThe web application that runs the website passes order information to virtual machines(VMs)," +
                                     "\nwhich further process each order.These VMs exist on an Azure virtual network," +
                                     "\nbut they need to access the internet to retrieve software packages and system updates." +
                                     "\nThe security team wants to ensure that only valid network traffic reaches the company's Azure resources." +
                                     "\nAs an extra layer of defense, the team also wants to ensure that the VMs can reach only trusted hosts on specific ports." +
                                     "\n\nHow can Tailwind Traders most easily implement a deny by default policy so that VMs can't connect to each other?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };
                var AnswersOfQ48 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Allocate each VM on its own virtual network."},
                        new Answer{ActualAnswer = "Create a network security group rule that prevents access from another VM on the same network."},
                        new Answer{ActualAnswer = "Configure Azure DDoS Protection to limit network access within the virtual network."},
                };
                db.Answers.AddRange(AnswersOfQ48);

                question48.Answers = AnswersOfQ48;
                question48.CorrectAnswer = AnswersOfQ48.FirstOrDefault(a => a.ActualAnswer == "Create a network security group rule that prevents access from another VM on the same network.");

                db.Add(question48);

                var question49 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, recall that retail employees are issued tablet devices from which they can track orders and plan their work schedules." +
                                    "\nTailwind Traders also allows delivery drivers to use their own mobile devices to access scheduling and logistics applications." +
                                    "\nA stolen password might allow unauthorized access to company and customer data." +
                                    "\nTailwind Traders wants to extend its investments in Active Directory to secure all of its applications," +
                                    "\n when accessed both from the intranet and from public networks." +
                                    "\nThe company is looking into how Azure Active Directory (Azure AD), single sign-on (SSO), multifactor authentication," +
                                    "\nand Conditional Access can help it achieve those goals." +
                                    "\n\nHow can the IT department ensure that employees at the company's retail stores can access company applications only from approved tablet devices?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ49 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "SSO"},
                        new Answer{ActualAnswer = "Conditional Access"},
                        new Answer{ActualAnswer = "Multifactor authentication"},
                };
                db.Answers.AddRange(AnswersOfQ49);

                question49.Answers = AnswersOfQ49;
                question49.CorrectAnswer = AnswersOfQ49.FirstOrDefault(a => a.ActualAnswer == "Conditional Access");

                db.Add(question49);

                var question50 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, recall that retail employees are issued tablet devices from which they can track orders and plan their work schedules." +
                                    "\nTailwind Traders also allows delivery drivers to use their own mobile devices to access scheduling and logistics applications." +
                                    "\nA stolen password might allow unauthorized access to company and customer data." +
                                    "\nTailwind Traders wants to extend its investments in Active Directory to secure all of its applications," +
                                    "\n when accessed both from the intranet and from public networks." +
                                    "\nThe company is looking into how Azure Active Directory (Azure AD), single sign-on (SSO), multifactor authentication," +
                                    "\nand Conditional Access can help it achieve those goals." +
                                    "\n\nHow can the IT department use biometric properties, such as facial recognition, to enable delivery drivers to prove their identities?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ50 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "SSO"},
                        new Answer{ActualAnswer = "Conditional Access"},
                        new Answer{ActualAnswer = "Multifactor authentication"},
                };
                db.Answers.AddRange(AnswersOfQ50);

                question50.Answers = AnswersOfQ50;
                question50.CorrectAnswer = AnswersOfQ50.FirstOrDefault(a => a.ActualAnswer == "Multifactor authentication");

                db.Add(question50);

                var question51 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, recall that retail employees are issued tablet devices from which they can track orders and plan their work schedules." +
                                    "\nTailwind Traders also allows delivery drivers to use their own mobile devices to access scheduling and logistics applications." +
                                    "\nA stolen password might allow unauthorized access to company and customer data." +
                                    "\nTailwind Traders wants to extend its investments in Active Directory to secure all of its applications," +
                                    "\n when accessed both from the intranet and from public networks." +
                                    "\nThe company is looking into how Azure Active Directory (Azure AD), single sign-on (SSO), multifactor authentication," +
                                    "\nand Conditional Access can help it achieve those goals." +
                                    "\n\nHow can the IT department reduce the number of times users must authenticate to access multiple applications?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ51 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "SSO"},
                        new Answer{ActualAnswer = "Conditional Access"},
                        new Answer{ActualAnswer = "Multifactor authentication"},
                };
                db.Answers.AddRange(AnswersOfQ51);

                question51.Answers = AnswersOfQ51;
                question51.CorrectAnswer = AnswersOfQ51.FirstOrDefault(a => a.ActualAnswer == "SSO");

                db.Add(question51);

                var question52 = new Question
                {
                    ActualQuestion = "Tailwind Traders has created environments for development and testing for its e-commerce system." +
                                    "\nAlthough the development and test teams report to different departments, " +
                                    "\nboth environments exist under the same Azure subscription." +
                                    "\nThe IT manager wants to implement governance controls to help ensure that only authorized users can access these systems. " +
                                    "\nHaving these controls in place will also help them track and manage operating costs." +
                                    "\n\nHow can Tailwind Traders allow some users to control the virtual machines in each environment but prevent them from modifying networking and other resources in the same resource group or Azure subscription?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ52 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Create a role assignment through Azure role-based access control (Azure RBAC)."},
                        new Answer{ActualAnswer = "Create a policy in Azure Policy that audits resource usage."},
                        new Answer{ActualAnswer = "Split the environment into separate resource groups."},
                };
                db.Answers.AddRange(AnswersOfQ52);

                question52.Answers = AnswersOfQ52;
                question52.CorrectAnswer = AnswersOfQ52.FirstOrDefault(a => a.ActualAnswer == "Create a role assignment through Azure role-based access control (Azure RBAC).");

                db.Add(question52);

                var question53 = new Question
                {
                    ActualQuestion = "Tailwind Traders has created environments for development and testing for its e-commerce system." +
                                    "\nAlthough the development and test teams report to different departments, " +
                                    "\nboth environments exist under the same Azure subscription." +
                                    "\nThe IT manager wants to implement governance controls to help ensure that only authorized users can access these systems. " +
                                    "\nHaving these controls in place will also help them track and manage operating costs." +
                                    "\n\nWhich is the best way for Tailwind Traders to ensure that the team deploys only cost-effective virtual machine SKU sizes?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ53 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Create a policy in Azure Policy that specifies the allowed SKU sizes."},
                        new Answer{ActualAnswer = "Periodically inspect the deployment manually to see which SKU sizes are used."},
                        new Answer{ActualAnswer = "Create an Azure RBAC role that defines the allowed virtual machine SKU sizes."},
                };
                db.Answers.AddRange(AnswersOfQ53);

                question53.Answers = AnswersOfQ53;
                question53.CorrectAnswer = AnswersOfQ53.FirstOrDefault(a => a.ActualAnswer == "Create a policy in Azure Policy that specifies the allowed SKU sizes.");

                db.Add(question53);

                var question54 = new Question
                {
                    ActualQuestion = "Tailwind Traders has created environments for development and testing for its e-commerce system." +
                                    "\nAlthough the development and test teams report to different departments, " +
                                    "\nboth environments exist under the same Azure subscription." +
                                    "\nThe IT manager wants to implement governance controls to help ensure that only authorized users can access these systems. " +
                                    "\nHaving these controls in place will also help them track and manage operating costs." +
                                    "\n\nWhich is likely the best way for Tailwind Traders to identify which billing department each Azure resource belongs to?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ54 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Track resource usage in a spreadsheet."},
                        new Answer{ActualAnswer = "Split the deployment into separate Azure subscriptions, where each subscription belongs to its own billing department."},
                        new Answer{ActualAnswer = "Apply a tag to each resource that includes the associated billing department."},
                };
                db.Answers.AddRange(AnswersOfQ54);

                question54.Answers = AnswersOfQ54;
                question54.CorrectAnswer = AnswersOfQ54.FirstOrDefault(a => a.ActualAnswer == "Apply a tag to each resource that includes the associated billing department.");

                db.Add(question54);

                var question55 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, the legal and IT departments want to better understand how Microsoft handles personal data." +
                                    "\nThey also want to better understand how Azure services can help them meet their compliance goals." +
                                    "\nTheir needs go beyond just Azure. For example, applications in their retail stores use Cortana to help store employees quickly locate items." +
                                    "\n\nWhere can the team access details about the personal data Microsoft processes and how the company processes it, including for Cortana?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ55 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Microsoft Privacy Statement"},
                        new Answer{ActualAnswer = "The Azure compliance documentation"},
                        new Answer{ActualAnswer = "Microsoft compliance offerings"},
                };
                db.Answers.AddRange(AnswersOfQ55);

                question55.Answers = AnswersOfQ55;
                question55.CorrectAnswer = AnswersOfQ55.FirstOrDefault(a => a.ActualAnswer == "Microsoft Privacy Statement");

                db.Add(question55);

                var question56 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, the legal and IT departments want to better understand how Microsoft handles personal data." +
                                   "\nThey also want to better understand how Azure services can help them meet their compliance goals." +
                                   "\nTheir needs go beyond just Azure. For example, applications in their retail stores use Cortana to help store employees quickly locate items." +
                                   "\n\nWhere can the legal team access information around how the Microsoft cloud helps them secure sensitive data and comply with applicable laws and regulations?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ56 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Microsoft Privacy Statement"},
                        new Answer{ActualAnswer = "Trust Center"},
                        new Answer{ActualAnswer = "Online Services Terms"},
                };
                db.Answers.AddRange(AnswersOfQ56);

                question56.Answers = AnswersOfQ56;
                question56.CorrectAnswer = AnswersOfQ56.FirstOrDefault(a => a.ActualAnswer == "Trust Center");

                db.Add(question56);

                var question57 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, the legal and IT departments want to better understand how Microsoft handles personal data." +
                                   "\nThey also want to better understand how Azure services can help them meet their compliance goals." +
                                   "\nTheir needs go beyond just Azure. For example, applications in their retail stores use Cortana to help store employees quickly locate items." +
                                   "\n\nWhere can the IT department find reference blueprints that it can apply directly to its Azure subscriptions?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AnswersOfQ57 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Online Services Terms"},
                        new Answer{ActualAnswer = "Azure compliance documentation"},
                        new Answer{ActualAnswer = "Microsoft Privacy Statement"},
                };
                db.Answers.AddRange(AnswersOfQ57);

                question57.Answers = AnswersOfQ57;
                question57.CorrectAnswer = AnswersOfQ57.FirstOrDefault(a => a.ActualAnswer == "Azure compliance documentation");

                db.Add(question57);

                var question58 = new Question
                {
                    ActualQuestion = "Before they migrate their existing e-commerce system from their datacenter to production environments on Azure," +
                                   "\nthe Tailwind Traders team wants to first set up environments for development and testing." +
                                   "\nAn e-commerce system might require a website, the products database, a payment system, and so on." +
                                   "\nBecause developers can't always run the entire service from their local development environment," +
                                   "\nthe Dev environment is the first place where everything the app needs comes together." +
                                   "\nAfter the development team verifies changes to the Dev environment, they promote changes to the Test environment." +
                                   "\nThe Test environment is where the testing team verifies new app features and also verifies that no regressions," +
                                   "\nor breaks to existing features, happen as new features are added." +
                                   "\nThe team will map each component in their existing infrastructure to the appropriate Azure service." +
                                   "\n\nWhich is the best first step the team should take to compare the cost of running these environments on Azure versus in their datacenter?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AnswersOfQ58 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "They're just test environments. Spin them up and check the bill at the end of the month."},
                        new Answer{ActualAnswer = "Assume that running in the cloud costs about the same as running in the datacenter."},
                        new Answer{ActualAnswer = "Run the Total Cost of Ownership Calculator."},
                };
                db.Answers.AddRange(AnswersOfQ58);

                question58.Answers = AnswersOfQ58;
                question58.CorrectAnswer = AnswersOfQ58.FirstOrDefault(a => a.ActualAnswer == "Run the Total Cost of Ownership Calculator.");

                db.Add(question58);

                var question59 = new Question
                {
                    ActualQuestion = "Before they migrate their existing e-commerce system from their datacenter to production environments on Azure," +
                                   "\nthe Tailwind Traders team wants to first set up environments for development and testing." +
                                   "\nAn e-commerce system might require a website, the products database, a payment system, and so on." +
                                   "\nBecause developers can't always run the entire service from their local development environment," +
                                   "\nthe Dev environment is the first place where everything the app needs comes together." +
                                   "\nAfter the development team verifies changes to the Dev environment, they promote changes to the Test environment." +
                                   "\nThe Test environment is where the testing team verifies new app features and also verifies that no regressions," +
                                   "\nor breaks to existing features, happen as new features are added." +
                                   "\nThe team will map each component in their existing infrastructure to the appropriate Azure service." +
                                   "\n\nWhat's the best way to ensure that the development team doesn't provision too many virtual machines at the same time?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AnswersOfQ59 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Do nothing. Let the development team use what they need."},
                        new Answer{ActualAnswer = "Apply spending limits to the development team's Azure subscription."},
                        new Answer{ActualAnswer = "Verbally give the development lead a budget and hold them accountable for overages."},
                };
                db.Answers.AddRange(AnswersOfQ59);

                question59.Answers = AnswersOfQ59;
                question59.CorrectAnswer = AnswersOfQ59.FirstOrDefault(a => a.ActualAnswer == "Apply spending limits to the development team's Azure subscription.");

                db.Add(question59);

                var question60 = new Question
                {
                    ActualQuestion = "Before they migrate their existing e-commerce system from their datacenter to production environments on Azure," +
                                   "\nthe Tailwind Traders team wants to first set up environments for development and testing." +
                                   "\nAn e-commerce system might require a website, the products database, a payment system, and so on." +
                                   "\nBecause developers can't always run the entire service from their local development environment," +
                                   "\nthe Dev environment is the first place where everything the app needs comes together." +
                                   "\nAfter the development team verifies changes to the Dev environment, they promote changes to the Test environment." +
                                   "\nThe Test environment is where the testing team verifies new app features and also verifies that no regressions," +
                                   "\nor breaks to existing features, happen as new features are added." +
                                   "\nThe team will map each component in their existing infrastructure to the appropriate Azure service." +
                                   "\n\nWhich is the most efficient way for the testing team to save costs on virtual machines on weekends, when testers are not at work?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AnswersOfQ60 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Delete the virtual machines before the weekend and create a new set the following week."},
                        new Answer{ActualAnswer = "Deallocate virtual machines when they're not in use."},
                        new Answer{ActualAnswer = "Just let everything run. Azure bills you only for the CPU time that you use."},
                };
                db.Answers.AddRange(AnswersOfQ60);

                question60.Answers = AnswersOfQ60;
                question60.CorrectAnswer = AnswersOfQ60.FirstOrDefault(a => a.ActualAnswer == "Deallocate virtual machines when they're not in use.");

                db.Add(question60);

                var question61 = new Question
                {
                    ActualQuestion = "Before they migrate their existing e-commerce system from their datacenter to production environments on Azure," +
                                  "\nthe Tailwind Traders team wants to first set up environments for development and testing." +
                                  "\nAn e-commerce system might require a website, the products database, a payment system, and so on." +
                                  "\nBecause developers can't always run the entire service from their local development environment," +
                                  "\nthe Dev environment is the first place where everything the app needs comes together." +
                                  "\nAfter the development team verifies changes to the Dev environment, they promote changes to the Test environment." +
                                  "\nThe Test environment is where the testing team verifies new app features and also verifies that no regressions," +
                                  "\nor breaks to existing features, happen as new features are added." +
                                  "\nThe team will map each component in their existing infrastructure to the appropriate Azure service." +
                                  "\n\nResources in the Dev and Test environments are each paid for by different departments. What's the best way to categorize costs by department?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AnswersOfQ61 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Apply a tag to each virtual machine that identifies the appropriate billing department."},
                        new Answer{ActualAnswer = "Split the cost evenly between departments."},
                        new Answer{ActualAnswer = "Keep a spreadsheet that lists each team's resources."},
                };
                db.Answers.AddRange(AnswersOfQ61);

                question61.Answers = AnswersOfQ61;
                question61.CorrectAnswer = AnswersOfQ61.FirstOrDefault(a => a.ActualAnswer == "Apply a tag to each virtual machine that identifies the appropriate billing department.");

                db.Add(question61);

                var question62 = new Question
                {
                    ActualQuestion = "Tailwind Traders' Special Orders application includes two virtual machines, Azure Load Balancer, and Azure SQL Database." +
                                  "\nHere's the service-level agreement (SLA) for each service:" +
                                  "\nAzure Virtual Machines :       	99.9 percent" +
                                  "\nAzure SQL Database	:             99.99 percent" +
                                  "\nAzure Load Balancer :             99.99 percent" +
                                  "\nTo compute the composite SLA for a set of services, you multiply the SLA of each individual service. Recall that the existing composite SLA is:" +
                                  "\n\n99.9% X 99.9% X 99.99% X 99.99% = 99.78% " +
                                  "\n\nThe team wants to add a mapping feature so that it can calculate routes between nearby suppliers and each retail store. For that, the team will use Azure Maps." +
                                  "\nThe team also needs more processing power to keep up with demand. For that, it will add a third virtual machine to the pool." +
                                  "\nTailwind Traders is also considering using an augmented reality service in the Special Orders app to help customers visualize their customizations." +
                                  "\nThis Azure service is currently in the public preview phase." +
                                  "\nyou can access SLAs from : https://azure.microsoft.com/nl-nl/support/legal/sla/" +
                                  "\n\nWhat's the SLA for Azure Maps in terms of guaranteed uptime?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AnswersOfQ62 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "99 percent"},
                        new Answer{ActualAnswer = "99.9 percent"},
                        new Answer{ActualAnswer = "99.99 percent"},
                };
                db.Answers.AddRange(AnswersOfQ62);

                question62.Answers = AnswersOfQ62;
                question62.CorrectAnswer = AnswersOfQ62.FirstOrDefault(a => a.ActualAnswer == "99.9 percent");

                db.Add(question62);

                var question63 = new Question
                {
                    ActualQuestion = "Tailwind Traders' Special Orders application includes two virtual machines, Azure Load Balancer, and Azure SQL Database." +
                                  "\nHere's the service-level agreement (SLA) for each service:" +
                                  "\nAzure Virtual Machines :       	99.9 percent" +
                                  "\nAzure SQL Database	:             99.99 percent" +
                                  "\nAzure Load Balancer :             99.99 percent" +
                                  "\nTo compute the composite SLA for a set of services, you multiply the SLA of each individual service. Recall that the existing composite SLA is:" +
                                  "\n\n99.9% X 99.9% X 99.99% X 99.99% = 99.78% " +
                                  "\n\nThe team wants to add a mapping feature so that it can calculate routes between nearby suppliers and each retail store. For that, the team will use Azure Maps." +
                                  "\nThe team also needs more processing power to keep up with demand. For that, it will add a third virtual machine to the pool." +
                                  "\nTailwind Traders is also considering using an augmented reality service in the Special Orders app to help customers visualize their customizations." +
                                  "\nThis Azure service is currently in the public preview phase." +
                                  "\nyou can access SLAs from : https://azure.microsoft.com/nl-nl/support/legal/sla/" +
                                  "\n\nWhat's the new composite SLA? Remember, the new SLA includes a third virtual machine and Azure Maps.",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AnswersOfQ63 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "99.58 percent"},
                        new Answer{ActualAnswer = "99.78 percent"},
                        new Answer{ActualAnswer = "99.99 percent"},
                };
                db.Answers.AddRange(AnswersOfQ63);

                question63.Answers = AnswersOfQ63;
                question63.CorrectAnswer = AnswersOfQ63.FirstOrDefault(a => a.ActualAnswer == "99.58 percent");

                db.Add(question63);

                var question64 = new Question
                {
                    ActualQuestion = "Tailwind Traders' Special Orders application includes two virtual machines, Azure Load Balancer, and Azure SQL Database." +
                                  "\nHere's the service-level agreement (SLA) for each service:" +
                                  "\nAzure Virtual Machines :       	99.9 percent" +
                                  "\nAzure SQL Database	:             99.99 percent" +
                                  "\nAzure Load Balancer :             99.99 percent" +
                                  "\nTo compute the composite SLA for a set of services, you multiply the SLA of each individual service. Recall that the existing composite SLA is:" +
                                  "\n\n99.9% X 99.9% X 99.99% X 99.99% = 99.78% " +
                                  "\n\nThe team wants to add a mapping feature so that it can calculate routes between nearby suppliers and each retail store. For that, the team will use Azure Maps." +
                                  "\nThe team also needs more processing power to keep up with demand. For that, it will add a third virtual machine to the pool." +
                                  "\nTailwind Traders is also considering using an augmented reality service in the Special Orders app to help customers visualize their customizations." +
                                  "\nThis Azure service is currently in the public preview phase." +
                                  "\n\nAdding a third virtual machine reduces the composite SLA. How can Tailwind Traders offset this reduction?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AnswersOfQ64 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "Increase the size of each virtual machine."},
                        new Answer{ActualAnswer = "Deploy extra instances of the same virtual machines across the different availability zones in the same Azure region."},
                        new Answer{ActualAnswer = "Do nothing. Using Azure Load Balancer increases the SLA for virtual machines."},
                };
                db.Answers.AddRange(AnswersOfQ64);

                question64.Answers = AnswersOfQ64;
                question64.CorrectAnswer = AnswersOfQ64.FirstOrDefault(a => a.ActualAnswer == "Deploy extra instances of the same virtual machines across the different availability zones in the same Azure region.");

                db.Add(question64);

                var question65 = new Question
                {
                    ActualQuestion = "Tailwind Traders' Special Orders application includes two virtual machines, Azure Load Balancer, and Azure SQL Database." +
                                  "\nHere's the service-level agreement (SLA) for each service:" +
                                  "\nAzure Virtual Machines :       	99.9 percent" +
                                  "\nAzure SQL Database	:             99.99 percent" +
                                  "\nAzure Load Balancer :             99.99 percent" +
                                  "\nTo compute the composite SLA for a set of services, you multiply the SLA of each individual service. Recall that the existing composite SLA is:" +
                                  "\n\n99.9% X 99.9% X 99.99% X 99.99% = 99.78% " +
                                  "\n\nThe team wants to add a mapping feature so that it can calculate routes between nearby suppliers and each retail store. For that, the team will use Azure Maps." +
                                  "\nThe team also needs more processing power to keep up with demand. For that, it will add a third virtual machine to the pool." +
                                  "\nTailwind Traders is also considering using an augmented reality service in the Special Orders app to help customers visualize their customizations." +
                                  "\nThis Azure service is currently in the public preview phase." +
                                  "\n\nWhat approach might the company take in adding the augmented reality (AR) preview service to its architecture?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AnswersOfQ65 = new List<Answer>()
                {
                        new Answer{ActualAnswer = "The Special Orders app is already in production. The company shouldn't look into the AR service until the service reaches general availability (GA)."},
                        new Answer{ActualAnswer = "The Special Orders app is mainly for use by retail employees. The company can integrate the AR service now because potential downtime or failures aren't an important factor."},
                        new Answer{ActualAnswer = "The development team can create a prototype version of the app that includes the AR service that it tests out with select retail employees."},
                };
                db.Answers.AddRange(AnswersOfQ65);

                question65.Answers = AnswersOfQ65;
                question65.CorrectAnswer = AnswersOfQ65.FirstOrDefault(a => a.ActualAnswer == "The development team can create a prototype version of the app that includes the AR service that it tests out with select retail employees.");

                db.Add(question65);

                db.SaveChanges();
            }
        }
    }
}
