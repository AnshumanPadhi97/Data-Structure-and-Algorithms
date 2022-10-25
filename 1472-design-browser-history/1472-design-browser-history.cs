public class BrowserHistory {

    Stack<string> b = new Stack<string>();
    Stack<string> f = new Stack<string>();
    
    public BrowserHistory(string homepage) {
        b.Push(homepage);
    }
    
    public void Visit(string url) {
        b.Push(url);
        f.Clear();
    }
    
    public string Back(int steps) {
        while(b.Count>1 && steps>0){
            f.Push(b.Pop());
            steps--;
        }
        return b.Peek();
    }
    
    public string Forward(int steps) {
        while(f.Count>0 && steps>0){
            steps--;
            b.Push(f.Pop());
        }
        return b.Peek();
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */