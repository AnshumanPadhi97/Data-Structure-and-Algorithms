public class Solution {
    public bool IsRobotBounded(string s) {
        if(s.Length==0)return false;
        var x=0;
        var y=0;
        var dir=2;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='G'){
                if(dir==1){
                    x++;
                }
                else if(dir==-1){
                    x--;
                }
                else if(dir==2){
                    y++;
                }else{
                    y--;
                }
            }
            else if(s[i]=='L'){
                if(dir==1){
                    dir=2;
                }
                else if(dir==-1){
                    dir=-2;
                }
                else if(dir==2){
                    dir=-1;
                }else if(dir==-2){
                    dir=1;
                }
            }
            else{
                if(dir==1){
                    dir=-2;
                }
                else if(dir==-1){
                    dir=2;
                }
                else if(dir==2){
                    dir=1;
                }else if(dir==-2){
                    dir=-1;
                }
            }
        }
        if(x==0 && y==0){
            return true;
        }
        if(dir==2)return false;
        return true;
    }
}