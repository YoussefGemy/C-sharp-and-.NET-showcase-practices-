using System.Runtime.Intrinsics.X86;

string[] bank=["011001","000000","010100","001000"];
int  r1=0;
int r2=0;
int ans = 0;
for(int i=0;i<bank.Length;i++) {
    int cnt = 0;
    foreach (var ch in bank[i]) {
        if (ch == '1') cnt++;
    }
    if (cnt != 0){
        if (r1 == 0) {
            r1 = cnt;
            continue;
        }
        else if (r2 != 0) {
            r1 = r2;
        }
        r2 = cnt;
        ans += r1 * r2;
    }
}

Console.WriteLine(ans);