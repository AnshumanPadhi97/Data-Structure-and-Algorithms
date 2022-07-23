Skip all intervals which end before the start of the new interval, i.e., skip all intervals with the following condition:
intervals[i].end < newInterval.start
Let’s call the last interval ‘b’ that does not satisfy the above condition. If ‘b’ overlaps with the new interval (a) (i.e. b.start <= a.end), we need to merge them into a new interval ‘c’:
c.start = min(a.start, b.start)
c.end = max(a.end, b.end)
add rest of other remaining intervals