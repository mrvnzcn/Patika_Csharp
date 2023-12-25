using System;

namespace ToDoApp {
    public class Board
    {
        public Line TODO { get; set; } = new Line();
        public Line INPROGRESS { get; set; } = new Line();
        public Line DONE { get; set; } = new Line();
    }
    
}