// Aplicatie2.cpp : Defines the entry point for the application.
//

#include "framework.h"
#include "Aplicatie2.h"
#include <math.h>

#define MAX_LOADSTRING 100
#define ID_START_BUTTON 1001
#define ID_STOP_BUTTON 1002
#define ID_TIMER 1003
#define ID_STATIC_PRIME 1004

// Global Variables:
HINSTANCE hInst;                                // current instance
WCHAR szTitle[MAX_LOADSTRING];                  // The title bar text
WCHAR szWindowClass[MAX_LOADSTRING];            // the main window class name

int unghi = 0;
HWND hb_start, hb_stop, hs_prime;
HANDLE id_thread = 0;
int ultim_prim_calculat;
// Forward declarations of functions included in this code module:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // TODO: Place code here.

    // Initialize global strings
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_APLICATIE2, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Perform application initialization:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_APLICATIE2));

    MSG msg;

    // Main message loop:
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

    return (int) msg.wParam;
}



//
//  FUNCTION: MyRegisterClass()
//
//  PURPOSE: Registers the window class.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_APLICATIE2));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_APLICATIE2);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}

//
//   FUNCTION: InitInstance(HINSTANCE, int)
//
//   PURPOSE: Saves instance handle and creates main window
//
//   COMMENTS:
//
//        In this function, we save the instance handle in a global variable and
//        create and display the main program window.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Store instance handle in our global variable

   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, nullptr, nullptr, hInstance, nullptr);

   if (!hWnd)
   {
      return FALSE;
   }

   hb_start = CreateWindowW(
	   L"BUTTON",
	   L"Start",
	   WS_CHILD | WS_TABSTOP | WS_VISIBLE | BS_DEFPUSHBUTTON,
	   10, 10, 100, 40,
	   hWnd,
	   (HMENU)ID_START_BUTTON,
	   hInstance,
	   NULL
   
   );

   hb_stop = CreateWindowW(
	   L"BUTTON",
	   L"Stop",
	   WS_CHILD | WS_TABSTOP | WS_VISIBLE | BS_DEFPUSHBUTTON | WS_DISABLED,
	   120, 10, 100, 40,
	   hWnd,
	   (HMENU)ID_STOP_BUTTON,
	   hInstance,
	   NULL

   );

   hs_prime = CreateWindowW(
	   L"STATIC",
	   L"Prime",
	   WS_CHILD | WS_VISIBLE, 
	   230, 10, 100, 40,
	   hWnd,
	   (HMENU)ID_STATIC_PRIME,
	   hInstance,
	   NULL
);

   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);

   return TRUE;
}

//
//  FUNCTION: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  PURPOSE: Processes messages for the main window.
//
//  WM_COMMAND  - process the application menu
//  WM_PAINT    - Paint the main window
//  WM_DESTROY  - post a quit message and return
//
//
int este_prim(int n)
{
	for (int i = 2; i * i <= n; i++)
		if (n % i == 0)
			return 0;
	return 1;
}
void calcul_prime(void)
{
	for (int i = 2; i < 1e9; i++)
		if (este_prim(i))
			ultim_prim_calculat = i;

}
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_COMMAND:
	{
		int wmId = LOWORD(wParam);
		// Parse the menu selections:
		switch (wmId)
		{
		case IDM_ABOUT:
			DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
			break;
		case IDM_EXIT:
			DestroyWindow(hWnd);
			break;
		case ID_START_BUTTON:
			//MessageBox(hWnd, L"Salut", L"Titlu", MB_OK);
			SetTimer(
				hWnd,
				ID_TIMER,
				100,
				NULL
			);
			EnableWindow(hb_start, false);
			EnableWindow(hb_stop, true);

			if (id_thread == 0)
			id_thread = CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE)calcul_prime, NULL, 0, NULL);
			else
				ResumeThread(id_thread);
			break;
		case ID_STOP_BUTTON:
			SuspendThread(id_thread);
			KillTimer(hWnd, ID_TIMER);
			EnableWindow(hb_start, true);
			EnableWindow(hb_stop, false);
			break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
		}
	}
	break;
	case WM_PAINT:
	{
		PAINTSTRUCT ps;
		HDC hdc = BeginPaint(hWnd, &ps);
		// TODO: Add any drawing code that uses hdc here...
		int R = 150;
		int r = 10;

		int cx = 300 + R * cos(unghi / 180.0 * 3.14159);
		int cy = 300 + R * sin(unghi / 180.0 * 3.14159);

		Ellipse(hdc, cx - r, cy - r, cx + r, cy + r);
		EndPaint(hWnd, &ps);
	}
	break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;

	case WM_TIMER:
	{
		int wmId = LOWORD(wParam);
		switch (wmId)
		{
		case ID_TIMER:
			RECT r;
			r.left = 100;
			r.top = 100;
			r.right = 500;
			r.bottom = 500;
			InvalidateRect(hWnd, &r, true);
			unghi++;
			wchar_t sir[20];
			swprintf(sir, 20, L"%d", ultim_prim_calculat);
			SetWindowText(hs_prime, sir );
			break;
		}
	}
		break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

// Message handler for about box.
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}
