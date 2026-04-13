using System;
using System.Collections;

namespace part_one
{
    public class chats
    {
        // global arrays
        ArrayList holder = new ArrayList();
        ArrayList answers = new ArrayList();
        ArrayList ignore = new ArrayList();
        // constructor
        public chats()
        {
            // GENERAL
            holder.Add("how are you");
            answers.Add("I'm doing great and ready to help you stay safe online");

            holder.Add("purpose");
            answers.Add("My purpose is to teach you about cybersecurity and online safety.");

            holder.Add("what can i ask");
            answers.Add("You can ask me about passwords, phishing, safe browsing, viruses, and online safety tips.");

            // PASSWORDS
            holder.Add("password");
            answers.Add("Always use strong passwords with a mix of letters, numbers, and symbols.");

            holder.Add("strong password");
            answers.Add("A strong password should be long and not easy to guess.");

            // PHISHING
            holder.Add("phishing");
            answers.Add("Phishing is when scammers trick you into giving personal information through fake emails.");

            holder.Add("phishing email");
            answers.Add("Do not click links in emails that look suspicious or ask for personal details.");

            // SAFE BROWSING
            holder.Add("safe browsing");
            answers.Add("Always check website links and avoid clicking on unknown sites.");

            holder.Add("suspicious link");
            answers.Add("Never click on links from unknown sources, they may be dangerous.");

            // VIRUSES & MALWARE
            holder.Add("virus");
            answers.Add("A virus is harmful software that can damage your device or steal your data.");

            holder.Add("malware");
            answers.Add("Malware is software designed to harm your system or steal information.");

            // ONLINE SAFETY
            holder.Add("online safety");
            answers.Add("Never share personal information like passwords or banking details online.");

            holder.Add("scam");
            answers.Add("Scams try to trick you into giving money or information. Always be careful.");

            
            holder.Add("public wifi");
            answers.Add("Avoid logging into important accounts on public WiFi.");

            holder.Add("update software");
            answers.Add("Always keep your apps and software updated to stay protected.");

            holder.Add("antivirus");
            answers.Add("Use antivirus software to protect your device from threats.");

            holder.Add("download");
            answers.Add("Only download apps and files from trusted sources.");

            holder.Add("shared device");
            answers.Add("Always log out of accounts when using shared devices.");

            // EXIT
            holder.Add("exit");
            answers.Add("Goodbye! Stay safe online ");

            // ignore words
            ignore.Add("what");
            ignore.Add("is");
            ignore.Add("about");
            ignore.Add("how");
            ignore.Add("when ");
        }

        public void ai_chat(string name)
        {
            string asking = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(name + ": ");
                asking = Console.ReadLine().ToLower();
                Console.ResetColor();

            } while (respond(asking));
        }

        private bool respond(string question)
        {
            if (question == "exit")
            {
                Console.WriteLine("Bot: Bye...");
                return false;
            }

            string[] words = question.Split(' ');
            bool found = false;

            foreach (string word in words)
            {
                if (ignore.Contains(word))
                    continue;

                for (int i = 0; i < holder.Count; i++)
                {
                    if (word.Contains(holder[i].ToString()))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Bot: " + answers[i]);
                        Console.ResetColor();

                        found = true;
                        break;
                    }
                }

                if (found)
                    break;
            }

            // default response
            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase? ");
                Console.ResetColor();
            }

            return true;
        }
    }
}