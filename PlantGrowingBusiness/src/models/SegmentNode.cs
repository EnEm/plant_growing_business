using System.Drawing;
using System.Numerics;

abstract class SegmentNode : NodeInterface
{
    //  ID for the segment node
    int id;

    int id2;

    int id3;
    int id4;
    protected string getDescription()
    {
        return id.ToString();
    }

}