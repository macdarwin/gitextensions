                    input = GitCommandHelpers.ReEncodeFileName(input);
                        if (patch.Type == Patch.PatchType.ChangeFileMode)
                        {
                            patch.AppendTextLine(input);
                        }
                        else if (!IsIndexLine(input))
                        input = GitCommandHelpers.ReEncodeFileName(input);
                        if (IsUnlistedBinaryFileDelete(input))
            else if (input.StartsWith("old mode "))
                patch.Type = Patch.PatchType.ChangeFileMode;