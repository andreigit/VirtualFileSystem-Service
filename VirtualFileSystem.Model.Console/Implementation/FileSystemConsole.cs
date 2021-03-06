﻿using Common.Linq;
using System;
using System.Linq;
using System.Text;
using static System.FormattableString;

namespace VirtualFileSystem.Model.Console.Implementation
{
    using VirtualFileSystem.Common.Security;

    /// <summary>
    /// File System Console
    /// </summary>
    internal sealed class FileSystemConsole : IFileSystemConsole
    {

        private static StringComparer UserNameComparer => UserNameComparerProvider.Default;

        private static StringComparer FileSystemItemNameComparer => FileSystemItemNameComparerProvider.Default;

        private readonly IFileSystemItem root;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="root">File System Root Item</param>
        /// <exception cref="ArgumentNullException">Throws if the root is null</exception>
        /// <exception cref="ArgumentException">Throws if the item is not a root item</exception>
        public FileSystemConsole(IFileSystemItem root)
        {
            if (root is null)
                throw new ArgumentNullException(paramName: nameof(root));

            if (root.Kind != FileSystemItemKind.Root)
                throw new ArgumentException(paramName: nameof(root), message: "Item must be a root item.");

            this.root = root;
        }

        private static string DefaultVolumePath => PathUtils.Consts.ValidVolumeNames[0];

        private static string NormalizeCurrentDirectory(string currentDirectory) =>
            string.IsNullOrWhiteSpace(currentDirectory) ? DefaultVolumePath : currentDirectory.Trim();

        public string MakeDirectory(string currentDirectory, string directory)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);
            if (!PathUtils.IsAbsolutePath(directory))
                directory = PathUtils.CombinePath(currentDirectory, directory);

            string[] directoryParts = PathUtils.SplitPath(directory);

            IFileSystemItem currentItem = this.root;

            for (int i = 0; i < directoryParts.Length - 1; i++)
            {
                currentItem = currentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, directoryParts[i]));
                if (currentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (currentItem.Kind != FileSystemItemKind.Volume && currentItem.Kind != FileSystemItemKind.Directory)
                throw new FileSystemConsoleException("Destination path is not a volume or a directory.");

            currentItem.AddChildDirectory(directoryParts[directoryParts.Length - 1]);
            return directory;
        }

        public string ChangeDirectory(string currentDirectory, string directory)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);
            if (!PathUtils.IsAbsolutePath(directory))
                directory = PathUtils.CombinePath(currentDirectory, directory);

            string[] directoryParts = PathUtils.SplitPath(directory);

            IFileSystemItem currentItem = this.root;

            for (int i = 0; i < directoryParts.Length; i++)
            {
                currentItem = currentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, directoryParts[i]));
                if (currentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (currentItem.Kind != FileSystemItemKind.Volume && currentItem.Kind != FileSystemItemKind.Directory)
                throw new FileSystemConsoleException("Destination path is not a volume or a directory.");

            return directory;
        }

        public string RemoveDirectory(string currentDirectory, string directory)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);
            if (!PathUtils.IsAbsolutePath(directory))
                directory = PathUtils.CombinePath(currentDirectory, directory);

            string[] directoryParts = PathUtils.SplitPath(directory);

            IFileSystemItem currentItem = this.root;

            for (int i = 0; i < directoryParts.Length; i++)
            {
                currentItem = currentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, directoryParts[i]));
                if (currentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (currentItem.Kind != FileSystemItemKind.Directory)
                throw new FileSystemConsoleException("Destination path is not a directory.");

            currentItem.Parent.RemoveChildDirectory(currentItem.Name);

            return directory;
        }

        public string DeleteTree(string currentDirectory, string directory)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);
            if (!PathUtils.IsAbsolutePath(directory))
                directory = PathUtils.CombinePath(currentDirectory, directory);

            string[] directoryParts = PathUtils.SplitPath(directory);

            IFileSystemItem currentItem = this.root;

            for (int i = 0; i < directoryParts.Length; i++)
            {
                currentItem = currentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, directoryParts[i]));
                if (currentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (currentItem.Kind != FileSystemItemKind.Directory)
                throw new FileSystemConsoleException("Destination path is not a directory.");

            if (currentItem.HasLocks())
                throw new FileSystemConsoleException("Directory or its subdirectories contain one or more locked files.");

            currentItem.Parent.RemoveChildDirectoryWithTree(currentItem.Name);

            return directory;
        }

        public string MakeFile(string currentDirectory, string fileName)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);
            if (!PathUtils.IsAbsolutePath(fileName))
                fileName = PathUtils.CombinePath(currentDirectory, fileName);

            string[] directoryParts = PathUtils.SplitPath(fileName);

            IFileSystemItem currentItem = this.root;

            for (int i = 0; i < directoryParts.Length - 1; i++)
            {
                currentItem = currentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, directoryParts[i]));
                if (currentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (currentItem.Kind != FileSystemItemKind.Volume && currentItem.Kind != FileSystemItemKind.Directory)
                throw new FileSystemConsoleException("Destination path is not a volume or a directory.");

            currentItem.AddChildFile(directoryParts[directoryParts.Length - 1]);
            return fileName;
        }

        public string DeleteFile(string currentDirectory, string fileName)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);
            if (!PathUtils.IsAbsolutePath(fileName))
                fileName = PathUtils.CombinePath(currentDirectory, fileName);

            string[] directoryParts = PathUtils.SplitPath(fileName);

            IFileSystemItem currentItem = this.root;

            for (int i = 0; i < directoryParts.Length; i++)
            {
                currentItem = currentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, directoryParts[i]));
                if (currentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (currentItem.Kind != FileSystemItemKind.File)
                throw new FileSystemConsoleException("Destination path is not a file.");

            currentItem.Parent.RemoveChildFile(currentItem.Name);

            return fileName;
        }

        public string LockFile(string userName, string currentDirectory, string fileName)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);
            if (!PathUtils.IsAbsolutePath(fileName))
                fileName = PathUtils.CombinePath(currentDirectory, fileName);

            string[] directoryParts = PathUtils.SplitPath(fileName);

            IFileSystemItem currentItem = this.root;

            for (int i = 0; i < directoryParts.Length; i++)
            {
                currentItem = currentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, directoryParts[i]));
                if (currentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (currentItem.Kind != FileSystemItemKind.File)
                throw new FileSystemConsoleException("Destination path is not a file.");

            currentItem.Lock(userName);

            return fileName;
        }

        public string UnlockFile(string userName, string currentDirectory, string fileName)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);
            if (!PathUtils.IsAbsolutePath(fileName))
                fileName = PathUtils.CombinePath(currentDirectory, fileName);

            string[] directoryParts = PathUtils.SplitPath(fileName);

            IFileSystemItem currentItem = this.root;

            for (int i = 0; i < directoryParts.Length; i++)
            {
                currentItem = currentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, directoryParts[i]));
                if (currentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (currentItem.Kind != FileSystemItemKind.File)
                throw new FileSystemConsoleException("Destination path is not a file.");

            currentItem.Unlock(userName);

            return fileName;
        }

        private static void CopyItemTree(IFileSystemItem item, IFileSystemItem destItem)
        {
            if (item.Kind != FileSystemItemKind.Directory && item.Kind != FileSystemItemKind.File)
                throw new ArgumentException(Invariant($"{nameof(item)} is not a directory or a file."), nameof(item));

            if (destItem.Kind != FileSystemItemKind.Volume && destItem.Kind != FileSystemItemKind.Directory)
                throw new ArgumentException(Invariant($"{nameof(destItem)} is not a volume or directory."), nameof(item));

            IFileSystemItem CopyItem()
            {
                switch (item.Kind)
                {
                    case FileSystemItemKind.Directory:
                        return destItem.AddChildDirectory(item.Name);
                    case FileSystemItemKind.File:
                        return destItem.AddChildFile(item.Name);
                    default:
                        throw new ArgumentException(Invariant($"{nameof(item)} is not a directory or a file."), nameof(item));
                }
            }

            IFileSystemItem itemCopy = CopyItem();

            item.ChildItems.ForEach(child => CopyItemTree(child, itemCopy));
        }

        private void CopyOrMoveInternal(
            string currentDirectory,
            string sourcePath,
            string destPath,
            Action<IFileSystemItem, IFileSystemItem> action)
        {
            currentDirectory = NormalizeCurrentDirectory(currentDirectory);

            if (!PathUtils.IsAbsolutePath(sourcePath))
                sourcePath = PathUtils.CombinePath(currentDirectory, sourcePath);

            if (!PathUtils.IsAbsolutePath(destPath))
                destPath = PathUtils.CombinePath(currentDirectory, destPath);

            string[] sourcePathParts = PathUtils.SplitPath(sourcePath);

            IFileSystemItem sourcePathCurrentItem = this.root;

            for (int i = 0; i < sourcePathParts.Length; i++)
            {
                sourcePathCurrentItem = sourcePathCurrentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, sourcePathParts[i]));
                if (sourcePathCurrentItem is null)
                    throw new FileSystemConsoleException("Source path is not exists.");
            }

            if (sourcePathCurrentItem.Kind != FileSystemItemKind.Directory && sourcePathCurrentItem.Kind != FileSystemItemKind.File)
                throw new FileSystemConsoleException(Invariant($"'{sourcePath}' is not a directory or a file."));

            if (sourcePathCurrentItem.Kind == FileSystemItemKind.File)
            {
                if (sourcePathCurrentItem.IsLocked)
                    throw new FileSystemConsoleException(Invariant($"File '{sourcePath}' is locked."));
            }

            string[] destPathParts = PathUtils.SplitPath(destPath);

            IFileSystemItem destPathCurrentItem = this.root;

            for (int i = 0; i < destPathParts.Length; i++)
            {
                destPathCurrentItem = destPathCurrentItem.ChildItems.FirstOrDefault(item => FileSystemItemNameComparer.Equals(item.Name, destPathParts[i]));
                if (destPathCurrentItem is null)
                    throw new FileSystemConsoleException("Destination path is not exists.");
            }

            if (destPathCurrentItem.Kind != FileSystemItemKind.Volume && destPathCurrentItem.Kind != FileSystemItemKind.Directory)
                throw new FileSystemConsoleException(Invariant($"'{destPath}' is not a volume or a directory."));

            if (sourcePathCurrentItem == destPathCurrentItem)
                throw new FileSystemConsoleException("Source path and destination path must be not equal.");

            if (sourcePathCurrentItem.Parent == destPathCurrentItem)
                throw new FileSystemConsoleException("Source path cannot be copied or moved to its parent.");

            if (sourcePathCurrentItem.Kind == FileSystemItemKind.Directory)
            {
                IFileSystemItem destPathCurrentItemParent = destPathCurrentItem.Parent;
                while (!(destPathCurrentItemParent is null))
                {
                    if (destPathCurrentItemParent == sourcePathCurrentItem)
                        throw new FileSystemConsoleException("Source directory cannot be a parent of the dest directory.");

                    destPathCurrentItemParent = destPathCurrentItemParent.Parent;
                }
            }

            if (sourcePathCurrentItem.HasLocks())
                throw new FileSystemConsoleException("Source path contain one or more locked files and cannot be copied or moved.");

            action(sourcePathCurrentItem, destPathCurrentItem);
        }

        public void Copy(string currentDirectory, string sourcePath, string destPath) => CopyOrMoveInternal(
            currentDirectory,
            sourcePath,
            destPath,
            (sourcePathCurrentItem, destPathCurrentItem) => CopyItemTree(sourcePathCurrentItem, destPathCurrentItem)
        );

        public void Move(string currentDirectory, string sourcePath, string destPath) => CopyOrMoveInternal(
            currentDirectory,
            sourcePath,
            destPath,
            (sourcePathCurrentItem, destPathCurrentItem) =>
            {
                IFileSystemItem prevParent = sourcePathCurrentItem.Parent;
                destPathCurrentItem.AddChild(sourcePathCurrentItem);
                prevParent.RemoveChild(sourcePathCurrentItem);
            }
        );

        private static void PrintItem(IFileSystemItem item, StringBuilder builder, bool printRoot)
        {
            if (item.Kind == FileSystemItemKind.Root && !printRoot)
                return;

            void AppendIndent()
            {
                int itemLevel = item.GetLevel();

                if (!printRoot)
                    itemLevel--;

                if (itemLevel > 0)
                {
                    for (int i = 0; i < itemLevel; i++)
                        builder.Append("| ");

                    builder[builder.Length - 1] = '_';
                }
            }

            string GetItemKindDescription()
            {
                switch (item.Kind)
                {
                    case FileSystemItemKind.Directory:
                        return " [DIR]";
                    case FileSystemItemKind.File:
                        return " [FILE]";
                    default:
                        return null;
                }
            }

            string GetLockedByDescription()
            {
                if (!item.IsLocked)
                    return null;

                var lockedByOrdered = item.LockedBy.OrderBy(userName => userName, UserNameComparer);
                return Invariant($" [LOCKED BY: {string.Join(", ", lockedByOrdered)}]");
            }

            if (builder.Length > 0)
                builder.AppendLine();

            AppendIndent();
            builder.Append(item.Name);
            builder.Append(GetItemKindDescription());
            builder.Append(GetLockedByDescription());
        }

        private static void PrintTreeHelper(IFileSystemItem item, StringBuilder builder, bool printRoot)
        {
            PrintItem(item, builder, printRoot);

            item.ChildItems.GroupBy(child => child.Kind).OrderBy(group => group.Key).ForEach(
                childGroup => childGroup.OrderBy(child => child.Name, FileSystemItemNameComparer).ForEach(
                    child => PrintTreeHelper(child, builder, printRoot)
                )
            );
        }

        public string PrintTree(bool printRoot)
        {
            var builder = new StringBuilder();
            PrintTreeHelper(this.root, builder, printRoot);
            return builder.ToString();
        }

    }

}
