﻿using BoardGame.Models.Tiles;

namespace BoardGame.Models.Builder;

public interface IBuildNodeGraph
{
    IMap Create(PlayFieldTil playFieldTils);
    void AddRight(IMap left, int idPlayFieldTil, PlayFieldTil playFieldTil);
    void AddLeft(IMap right, int idPlayFieldTil, PlayFieldTil playFieldTil);
    void AddTopRight(IMap topRight, int rootNodeId, PlayFieldTil playFieldTil);
    void AddTopLeft(IMap topLeft, int rootNodeId, PlayFieldTil playFieldTil);
    void AddBottomRight(IMap bottomRight, int rootNodeId, PlayFieldTil playFieldTil);
    void AddBottomLeft(IMap bottomLeft, int rootNodeId, PlayFieldTil playFieldTil);

}
