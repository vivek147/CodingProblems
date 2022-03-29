using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin
{
    public class MergeOverlappingInterval
    {
        //public static void Main()
        //{
        //    Interval i1 = new Interval(73, 99);
        //    Interval i2 = new Interval(46, 70);
        //    Interval i3 = new Interval(13, 94);
        //    Interval i4 = new Interval(89, 100);
        //    Interval i5 = new Interval(5, 55);

        //  //  (32, 75), (18, 36), (11, 77), (67, 70), (27, 89), (19, 21), (4, 66), 
        //    //(5, 55), (73, 99), (46, 70), (13, 94), (36, 94), (21, 22), (86, 94), (33, 66), (81, 97), (16, 37), (89, 100), (
        //    //(30, 63), (66, 94), (36, 87), (16, 86), (26, 85), (24, 50), (17, 84), (5, 25), (67, 81), (23, 54), (84, 99), (48, 85),
        //    //(23, 28), (3, 86), (63, 79), (18, 73), (6, 68), (34, 40), (61, 66), (60, 96), (95, 99), (1, 10), (4, 82), (19, 78), (23, 61),
        //    //(30, 45), (53, 87), (10, 42), (80, 93), (33, 73), (64, 65), (29, 71), (73, 89), (2, 98), (62, 67), (84, 98), (43, 58), (20, 45),
        //    //(86, 92), (22, 100), (72, 74), (5, 52), (48, 56), (69, 93), (8, 98), (37, 47), (19, 45), (22, 99), (34, 97), (21, 80), (58, 77), 
        //    //(48, 66), (59, 91), (18, 33), (2, 7), (8, 92), (12, 32), (17, 83), (11, 16), (60, 75)
        //    //, (9, 11), (3, 61), (4, 18), (53, 68), 
        //    //(17, 39),
        //    //(18, 93), (15, 55), (4, 34), (48, 85), (61, 65), (59, 77), (15, 37), (62, 82), (4, 78), (80, 96), (4, 42), (15, 48), (27, 45)

        //    List <Interval> interval = new List<Interval>();
        //    interval.Add(i1);interval.Add(i2); interval.Add(i3); interval.Add(i4);
        //    interval.Add(i5);

        //    var sortedinterval = interval.OrderBy(s => s.start).ToList();

        //    var result = MergeOverlappingIntervals(sortedinterval);
        //}

        private static List<Interval> MergeOverlappingIntervals(List<Interval> intervals)
        {
             var res = mergeUsingStack(intervals);
            // res= mergeRecursivey(intervals[0], intervals[1],1, intervals);

            return res;
        }

        private static List<Interval> mergeUsingStack(List<Interval> intervals)
        {
            Stack<Interval> intervalresStack = new Stack<Interval>();
            int lenghth = intervals.Count();

            for (int i = 0; i < lenghth ; i++)
            {
                if (intervalresStack.Count == 0)
                    intervalresStack.Push(intervals[i]);

                //(30, 63), (36, 87), (66, 94), 
                if (i>0)
                {
                    Interval peek = intervalresStack.Peek();
                    if (peek.end < intervals[i].start)
                        intervalresStack.Push(intervals[i]);
                    else
                    {
                        peek.end = Math.Max(intervals[i].end, peek.end);
                    }
                }
            }

            Stack<Interval> intervalsortedStack = new Stack<Interval>();
            while (intervalresStack.Count > 0)
            {
                intervalsortedStack.Push(intervalresStack.Pop());
            }

            return intervalsortedStack.ToList();
        }

        public static List<Interval> mergeRecursivey(Interval currentInterval , Interval nextInterval, int indextochek, List<Interval> intervals)
        {
            if (!(intervals.Count() > 1))
                return intervals;

            List<Interval> intrvl = new List<Interval>();

          
            if (currentInterval.end > nextInterval.start || currentInterval.end > nextInterval.end)
            {

                int end = currentInterval.end > nextInterval.end ? currentInterval.end : nextInterval.end;
                int start = currentInterval.start < nextInterval.start ? currentInterval.start : nextInterval.start;

                Interval mergedinterval = new Interval(start, end);
                indextochek = indextochek+1;

                if (intervals.Count()-1 >= indextochek)
                {
                    nextInterval = intervals[indextochek];
                    var intrvlres = mergeRecursivey(mergedinterval, nextInterval, indextochek, intervals);
                    intrvl.AddRange(intrvlres);
                }
                else
                    intrvl.Add(mergedinterval);
            }
            else
            {
                intrvl.Add(currentInterval);
               
                if (indextochek + 1 < intervals.Count())
                {
                    var inrvl = mergeRecursivey(nextInterval, intervals[indextochek + 1], indextochek + 1, intervals);
                    intrvl.AddRange(inrvl);
                }
                else
                {
                    intrvl.Add(nextInterval);
                }
            }

            return intrvl;
        }

        public class Interval
        {
            public int start;
            public int end;
            Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }
    }
}
