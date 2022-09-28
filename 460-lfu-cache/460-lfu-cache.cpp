struct Node{
    int key, value, cnt;
    Node *next;
    Node *prev;
    Node(int _key,int _value){
        key=_key;
        value=_value;
        cnt=1;
    }
};
struct List{
    int size;
    Node *head;
    Node *tail;
    List(){
        head=new Node(0,0);
        tail=new Node(0,0);
        head->next=tail;
        tail->prev=head;
        size=0;
    }
    void addFront(Node *node){
        Node *temp = head->next;
        node->next=temp;
        node->prev=head;
        head->next=node;
        temp->prev=node;
        size++;
    }
    void removeNode(Node* delNode){
        Node *delprev = delNode->prev;
        Node *delnext = delNode->next;
        delprev->next=delnext;
        delnext->prev=delprev;
        size--;
    }
};

class LFUCache {
public:
    map<int,Node*> keyNode;
    map<int,List*> freqList;
    int minFreq;
    int maxSize;
    int currSize;

    LFUCache(int capacity) {
        maxSize = capacity;
        minFreq=0;
        currSize=0;
    }
    
    void updateFreqMap(Node *node){
        keyNode.erase(node->key);
        freqList[node->cnt]->removeNode(node);
        if(node->cnt == minFreq && freqList[node->cnt]->size == 0){
            minFreq++;
        }

        List *nextHigherFreqList = new List();
        if(freqList.find(node->cnt+1)!=freqList.end()){
            nextHigherFreqList=freqList[node->cnt+1];
        }

        node->cnt+=1;
        nextHigherFreqList->addFront(node);
        freqList[node->cnt]=nextHigherFreqList;
        keyNode[node->key]=node;
    }

    int get(int key) {
        if(keyNode.find(key)!=keyNode.end()){
            Node *node = keyNode[key];
            int val = node->value;
            updateFreqMap(node);
            return val;
        }
        return -1;
    }
    
    void put(int key, int value) {
        if(maxSize == 0) return;
        if(keyNode.find(key)!=keyNode.end()){
            Node *node = keyNode[key];
            node->value = value;
            updateFreqMap(node);
        }else{
            if(currSize==maxSize){
                List *list = freqList[minFreq];
                keyNode.erase(list->tail->prev->key);
                freqList[minFreq]->removeNode(list->tail->prev);
                currSize--;
            }
            currSize++;
            minFreq=1;
            List *list = new List();
            if(freqList.find(minFreq)!=freqList.end()){
                list = freqList[minFreq];
            }
            Node *node = new Node(key,value);
            list->addFront(node);
            keyNode[key]=node;
            freqList[minFreq]=list;
        }
    }
};