class SGTree {
    vector<int> seg;
    vector<int> lazy;
public:
    SGTree(int n) {
        seg.resize(4 * n + 1);
        lazy.resize(4 * n + 1);
    }

    void build(int ind, int low, int high, int arr[]) {
        if (low == high) {
            seg[ind] = arr[low];
            return;
        }
        int mid = (low + high) / 2;
        build(2 * ind + 1, low, mid, arr);
        build(2 * ind + 2, mid + 1, high, arr);
        seg[ind] =seg[2 * ind + 1] + seg[2 * ind + 2];
    }

    int query(int ind, int low, int high, int l, int r) {
        
        //complete any pending updates before query this node
        if(lazy[ind]!=0){
            seg[ind] = (high - low + 1) * lazy[ind];
            if(low!=high){
                lazy[2*ind+1] += lazy[ind];
                lazy[2*ind+2] += lazy[ind];
            }
            lazy[ind]=0;
        }
        
        // no overlap
        // l r low high or low high l r
        if (r < low || high < l) return 0;
        
        // complete overlap
        // [l low high r]
        if (low >= l && high <= r) return seg[ind];

        //partial overlap        
        int mid = (low + high) >> 1;
        int left = query(2 * ind + 1, low, mid, l, r);
        int right = query(2 * ind + 2, mid + 1, high, l, r);
        return left + right;
    }
    void update(int ind, int low, int high, int i, int val) {
        //complete any pending updates before query this node
        if(lazy[ind]!=0){
            seg[ind] = (high - low + 1) * lazy[ind];
            if(low!=high){
                lazy[2*ind+1] += lazy[ind];
                lazy[2*ind+2] += lazy[ind];
            }
            lazy[ind]=0;
        }

        // no overlap
        // l r low high or low high l r
        if (r < low || high < l) return;

        if (low >= l && high <= r){
            seg[ind] += (high - low + 1) * val;
            if(low != high){
                lazy[2*ind+1] += lazy[ind];
                lazy[2*ind+2] += lazy[ind];
            }
            return;
        }

        int mid = (low + high) >> 1;
        if (i <= mid) update(2 * ind + 1, low, mid, i, val);
        else update(2 * ind + 2, mid + 1, high, i, val);
        
        seg[ind] = seg[2 * ind + 1] + seg[2 * ind + 2];
    }
};