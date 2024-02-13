using System.Drawing;
using System.Numerics;

abstract class SegmentNode : NodeInterface
{
    protected string getDescription()
    {
        return id.ToString();
    }

    //  ID for the segment node
    int id;
    int id2;
}