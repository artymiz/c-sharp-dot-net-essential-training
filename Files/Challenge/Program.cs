string[] officeExtensions = { ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx" };

string dirName = "FileCollection";

var officeFiles = Directory
    .EnumerateFiles(dirName)
    .Where(file => officeExtensions.Contains(Path.GetExtension(file)))
    .ToList();

long docCount = 0, xlsCount = 0, pptCount = 0;
long docSize = 0, xlsSize = 0, pptSize = 0;
long totalCount = 0, totalSize = 0;

foreach (string fileName in officeFiles) {
    FileInfo fileInfo = new FileInfo(fileName);
    totalCount++;
    totalSize += fileInfo.Length;

    switch (fileInfo.Extension.ToLower()) {
        case ".doc" or ".docx":
            docCount++;
            docSize += fileInfo.Length;
            break;
        case ".xls" or ".xlsx":
            xlsCount++;
            xlsSize += fileInfo.Length;
            break;
        case ".ppt" or ".pptx":
            pptCount++;
            pptSize += fileInfo.Length;
            break;
        default:
            break;
    }
}

string resultStr = $@"~~~Result~~~
Total files: {totalCount}
Excel Count: {xlsCount}
Word Count: {docCount}
PowerPoint Count: {pptCount}
----
Total size: {totalSize:N0}
Excel Size: {xlsSize:N0}
Word Size: {docSize:N0}
PowerPoint Size: {pptSize:N0}";

string resultFile = "result.txt";

using (StreamWriter sw = new StreamWriter(resultFile)) {
    sw.Write(resultStr);
}
