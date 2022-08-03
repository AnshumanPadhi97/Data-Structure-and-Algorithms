public class MyCalendar {
    List<int[]> ls= null;
    public MyCalendar() {
        ls=new List<int[]>();
    }
    
    public bool Book(int start, int end) {
        foreach(var item in ls){
            if(end>item[0] && start<item[1])
                return false;
        }
        ls.Add(new int[]{start,end});
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */