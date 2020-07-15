using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinCan;
using TinCan.LRSResponses;

namespace TinCanDotNet {
    class SaveStatement {
        public static void CommitStatement() {

            var lrs = Endpoint.EndpointConn();

            try {
                //Here we setup our default statement.
                var actor = new Agent {
                    mbox = "mailto:admin@crosstrainerlearning.com"
                };

                var verb = new Verb {
                    id = new Uri("http://crosstrainerdev.com/test/verbs/experienced"),
                    display = new LanguageMap()
                    //display.Add("en-US", "experienced"),
                };

                var activity = new Activity {
                    id = "http://crosstrainerdev.com/TinCan.NET"
                };

                var statement = new Statement {
                    actor = actor,
                    verb = verb,
                    target = activity
                };

                //We prepare to submit our statement.
                StatementLRSResponse lrsResponse = lrs.SaveStatement(statement);

                if (lrsResponse.success) {
                    //Our reciept of submission.
                    Console.WriteLine("Statement Saved: " + lrsResponse.content.id + "\n" + "Actor: " + actor + "\n" + "Verb: " + verb + "\n" + "Activity: " + activity);
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("Statement Not saved!");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
