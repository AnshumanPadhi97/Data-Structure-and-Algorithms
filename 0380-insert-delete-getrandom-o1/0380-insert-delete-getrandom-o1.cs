public class RandomizedSet {
    // For randomizing the list
    private Random r;
    
    // To determine if an item has been added, and store its list index
    private Dictionary<int, int> map;
    
    // To store the items added
    private List<int> values;

    public RandomizedSet() {
        r = new Random();
        map = new Dictionary<int, int>();
        values = new List<int>();
    }
    
    public bool Insert(int val) {
        // Determine if item exists in map
        if (map.ContainsKey(val)) {
            return false;
        }
        
        // Add value to the list
        values.Add(val);   

        // Save the value with its list index to the map
        map[val] = values.Count - 1;
        
        return true;
    }
    
    public bool Remove(int val) {
        // Determine if item exists in map
        if (!map.ContainsKey(val)) {
            return false;
        }
                
        // Get the current index for the item to remove
        var currentIndex = map[val];

        // Get the last index for the item at the end
        var lastIndex = values.Count - 1;

        // 'Swap' places of the last item in the list with the item to be removed
        values[currentIndex] = values[lastIndex];

        // Update the map for the item that we 'swapped' with its new list index
        map[values[currentIndex]] = currentIndex;

        // Remove the swapped item from the list (this is the item to be removed)
        values.RemoveAt(lastIndex);

        // Remove the item to be removed from the map
        map.Remove(val);
            
        return true;
    }
    
    public int GetRandom() {
        var randomIndex = r.Next(0, values.Count);
        return values[randomIndex];
    }
}