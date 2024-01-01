using Avalonia.Input;

namespace ShopDesktop.ViewModels;

public interface IDropTarget
{
    void DragOver(object? sender, DragEventArgs e);
    void Drop(object? sender, DragEventArgs e);
}