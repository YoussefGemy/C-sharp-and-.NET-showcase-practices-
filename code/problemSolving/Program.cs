public class Solution {
    public int MinOperations(int[] nums) {
        Dictionary<int,int>mp=new();
        for(int i=0;i<nums.Length;i++){
            if(mp.ContainsKey(nums[i])){
                mp[nums[i]]+=1;
            }
            else{
                mp.Add(nums[i],1);
            }
        }
        int ans=0;
        foreach(var v in mp){
            int u=v.Value;
            if(u==1){
                return -1;
            }
            else if(u==2){
                ans+=1;
            }
            else{
                ans+=(int)(u/3);
                u%=3;
                if(u!=0)ans+=1;
            }
        }
        return ans;
    }
}