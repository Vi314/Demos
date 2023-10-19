//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data; 
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////TODO Go over a simple monad implementation from zero
//namespace Demonstrations {

//    public sealed class Maybe<T> {
//        private readonly T value;

//        public bool HasValue { get; }

//        private Maybe(T value) {
//            this.value = value;
//            HasValue = true;
//        }

//        private Maybe() {
//            HasValue = false;
//        }

//        public static Maybe<T> Some(T value) {
//            if(value == null)
//                throw new ArgumentNullException(nameof(value));
//            return new Maybe<T>(value);
//        }

//        public static Maybe<T> None => new Maybe<T>();

//        public T Value {
//            get {
//                if(!HasValue)
//                    throw new InvalidOperationException("No value is present.");
//                return value;
//            }
//        }

//        public Maybe<TResult> Bind<TResult>(Func<T, Maybe<TResult>> bindFunc) {
//            if(bindFunc == null)
//                throw new ArgumentNullException(nameof(bindFunc));
//            return HasValue ? bindFunc(value) : Maybe<TResult>.None;
//        }

//    } 

//    public class MonadsDemo : IDemonstration {
//        public void Run() {

//            Book dune = new() {
//                Title = "Dune",
//                Description = "Sand and stuff",
//                PageCount = 420,
//                WrittenDate = DateTime.Now
//            };

//            Book duneTwo = new() {
//                Title = "DuneTWO",
//                Description = "Sand and stuff but god too",
//                PageCount = 420,
//                WrittenDate = DateTime.Now
//            };

//            List<Book> dunes = new() { dune, duneTwo };

//            var authors = dunes
//                                    .Bind(x => x.Select(x => x.Author))
//                                    .Bind(x => x.Select(x => x.Name));
//            foreach(var author in authors) {
//                Console.WriteLine(author);
//            }
//        }

//    }

//    public class Book {
//        public string Title { get; set; }
//        public string? Description { get; set; }
//        public DateTime WrittenDate { get; set; }
//        public int PageCount { get; set; }
//        public Author? Author { get; set; }
//    }

//    public class Author {
//        public Author(string name) {
//            Name = name;
//        }

//        public string Name { get; set; }
//    }

//}
