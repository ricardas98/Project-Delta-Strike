<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class DefaultController extends AbstractController
{
    /**
     * @Route("/", name="index")
     */
    public function index()
    {
        return $this->render('pages/index.html.twig', [
            'title' => 'Homepage',
        ]);
    }

    /**
     * @Route("/hub", name="hub")
     */
    public function hub()
    {
        return $this->render('pages/hub.html.twig', [
            'title' => 'Hub',
            'username' => '@username',
            'level' => '1 level',
        ]);
    }

    /**
     * @Route("/trading", name="trading")
     */
    public function trading()
    {
        return $this->render('pages/trading.html.twig');
    }

    /**
     * @Route("/achievements", name="achievements")
     */
    public function achievements()
    {
        return $this->render('pages/achievements.html.twig');
    }

    /**
     * @Route("/settings", name="settings")
     */
    public function settings()
    {
        return $this->render('pages/settings.html.twig');
    }

    /**
     * @Route("/items", name="items")
     */
    public function items()
    {
        return $this->render('pages/items.html.twig');
    }
}