using System;
using System.Reflection;

namespace CodeGenerator {

    class MainClass {

        public static void Main(string[] args) {

            if(args.Length != 1) {
                printUsage();
            } else {
                generate(args[0]);
            }

            Console.Read();
        }

        static void generate(string path) {
            try {

                var assembly = Assembly.LoadFrom(path);

                // Error
                // Could not load file or assembly '.../Assembly-CSharp.dll' or one of its dependencies

            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        static void printUsage() {
            Console.WriteLine("Usage:");
        }
    }
}
